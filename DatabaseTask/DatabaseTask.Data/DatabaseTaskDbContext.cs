using System;
using System.Collections.Generic;
using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }


        public DbSet<Employee> Employees { get; set; }
        public DbSet<Ametinimetused>? Ametinimetuseds { get; set; }
        public DbSet<Firma> Firmas { get; set; }
        public DbSet<Haiguslehed> Haigusleheds { get; set; }
        public DbSet<Harukontor> Harukontors { get; set; }
        public DbSet<Laenutus> Laenutused { get; set; }
        public DbSet<Lapsed>? Childrens { get; set; }
        public DbSet<Ligipääsuload>? Ligipääsuloads { get; set; }
        public DbSet<Puhkused> Puhkuseds { get; set; }
        public DbSet<Tervisekontroll> Tervisekontrolls { get; set; }
        public DbSet<Employee> Employee { get; set; }

    }
}
