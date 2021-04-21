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

        public DbSet<Color> Colors { get; set; }

        public DbSet<Favorite> Favorites { get; set; }

        public DbSet<Field> Fields { get; set; }

        public DbSet<Icon> Icons { get; set; }

        public DbSet<MyTask> MyTasks { get; set; }

        public DbSet<Option> Options { get; set; }

        public DbSet<Priority> Priorities { get; set; }

        public DbSet<Privacy> Privacies { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<ProjectMember> ProjectMembers { get; set; }

        public DbSet<ProjectResource> ProjectResources { get; set; }

        public DbSet<ProjectStatus> ProjectStatuses { get; set; }

        public DbSet<Section> Sections { get; set; }

        public DbSet<TaskCollaborator> TaskCollaborators { get; set; }

        public DbSet<TaskComment> TaskComments { get; set; }

        public DbSet<TaskProject> TaskProjects { get; set; }

        public DbSet<TaskStatus> TaskStatuses { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<TeamMember> TeamMembers { get; set; }

        public DbSet<User> Users { get; set; }


    }
}
