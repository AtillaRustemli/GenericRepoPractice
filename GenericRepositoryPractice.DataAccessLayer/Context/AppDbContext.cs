using GenericRepositoryPractice.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryPractice.DataAccessLayer.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Group> Groups { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>()
                .HasData(
                new Teacher {Id = 1,Name = "Atilla"},
                new Teacher { Id = 2,   Name = "Lorem"},
                new Teacher {Id =3,   Name = "Teacher"}

                );
            modelBuilder.Entity<Group>()
                .HasData(
                new Group { Id = 1,Name = "P416",TeacherId=1},
                new Group { Id = 2,   Name = "P516", TeacherId = 2 },
                new Group { Id =3,   Name = "P616", TeacherId = 3 }

                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
