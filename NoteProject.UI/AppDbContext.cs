using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteProject.UI
{
    public class AppDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet <Admin> Admins { get; set; }

        public DbSet <Notlar> Notlar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=AARDBEI;Initial Catalog=APPDB;User Id=sa;Password=Haxl;TrustServerCertificate=True;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //seed data içine id kesinlikle verilmesi gerekir
            modelBuilder.Entity<Admin>().HasData(
                new Admin
                { UserID = 1, Ad = "Sude", Soyad = "K", Sifre = "123", UserName = "admin" }
                );
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
