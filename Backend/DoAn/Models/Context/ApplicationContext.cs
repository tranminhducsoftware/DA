using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DoAn.Models.Context
{
    public class ApplicationContext : DbContext 
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        
        public DbSet<Account> Accounts { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Field> Fields { get; set; }

        public DbSet<FieldLevel> FieldLevels { get; set; }

        public DbSet<FieldTask> FieldTasks { get; set; }

        public DbSet<Member> Members { get; set; }

        public DbSet<OptionProject> OptionProjects { get; set; }

        public DbSet<Options> Options { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<ReportProject> ReportProjects { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<TaskMessage> TaskMessages { get; set; }

        public DbSet<TaskProject> TaskProjects { get; set; }

        public DbSet<TypeOptionProject> TypeOptionProjects { get; set; }

        public DbSet<TypeView> TypeViews { get; set; }

        public DbSet<TypeNotication> TypeNotications { get; set; }

        public DbSet<TypeMessageTask> TypeMessageTask { get; set; }
        
        public DbSet<Privacy> Privacy { get; set; }

        public DbSet<Milestone> Milestone { get; set; }

        public DbSet<Notification> Notification { get; set; }


    }
}
