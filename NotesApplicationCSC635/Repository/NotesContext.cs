using Microsoft.EntityFrameworkCore;
using NotesApplicationCSC635.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotesApplicationCSC635.Repository
{
    public class NotesContext : DbContext
    {
        public NotesContext(DbContextOptions<NotesContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Notes> Notes { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Notes>().ToTable("Notes");
            modelBuilder.Entity<User>().ToTable("User");
        }
    }
}
