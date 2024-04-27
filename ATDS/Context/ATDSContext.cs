using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ATDS.Context
{
    public class ATDSContext : DbContext
    {
        public virtual DbSet<Tasks> Task { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Departament> Departament { get; set; }
        public virtual DbSet<TasksType> TasksType { get; set; }
        public virtual DbSet<UserPosition> UserPosition { get; set; }
        public virtual DbSet<UserStatus> UserStatus { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }

        // public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tasks>().Property(x => x.id).HasColumnName("id");
            modelBuilder.Entity<Tasks>().Property(x => x.Title).HasColumnName("title");

            modelBuilder.Entity<Tasks>()
                .HasRequired(c => c.AssignedUser)
                .WithMany()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tasks>()
                .HasRequired(s => s.TaskInitiator)
            .WithMany()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tasks>().Property(c => c.StartDate).HasColumnAnnotation("Default", "getutcdate()");
            modelBuilder.Entity<Tasks>().Property(c => c.AssignedUserId).HasColumnAnnotation("Default", null);

            //  modelBuilder.Entity<Tasks>()
            //.Property(x => x.StartDate).Has
            //.HasDefaultValueSql("GETUTCDATE()");

        }
    }

}
