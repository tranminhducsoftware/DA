using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using DoAn.Data;
using DoAn.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Web.Services3.Referral;

namespace DoAn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class AuthenticationController : ControllerBase
    {
         /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationController"/> class.
        /// </summary>
        /// <param name="configuration">config.</param>
        /// <param name="context">context.</param>
        public AuthenticationController(IConfiguration configuration, IRepository<Account> context)
        {
            Configuration = configuration;
            Context = context;
        }

        private IConfiguration Configuration { get; }

        private IRepository<Account> Context { get; }

        /// <summary>
        /// Lấy token.
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Kết quả.</returns>
        [AllowAnonymous]
        [HttpPost("Tokens")]
        public async Task<IActionResult> Index([FromBody]UserLogin user)
        {
            var userInDb = (await Context.Get()).FirstOrDefault(x => x.Email == user.Email);
            if (userInDb == null)
            {
                return Ok( "Tài khoản không tồn tại");
            }

            if (user == null || !BCrypt.Net.BCrypt.Verify(user.Password ?? string.Empty, userInDb.Password))
            {
                return Ok( "Mật khẩu không chính xác");
            }

            // Tạo token.
            var claim = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Email),
            };
            var secret = Configuration["JwtConfig:Secret"];
            var issuer = Configuration["JwtConfig:Issuer"];

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var jwtToken = new JwtSecurityToken(
               issuer: issuer,
               claims: claim,
               expires: DateTime.Now.AddHours(Configuration.GetValue<int>("JwtConfig:ExpireTime")),
               signingCredentials: credentials);
            var token = new JwtSecurityTokenHandler().WriteToken(jwtToken);
            return Ok(new
            {
                token = token,
            });
        }
    }
}
