using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Repository.Configuration
{
    public class DataContext : DbContext
    {
        public DbSet<Tenancy> Tenancy { get; set; }

        public DbSet<ResidentialManagement> ResidentialManagement { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Exercicios\AbsoluteIT\ProofOfConcept\Infrastructure\AbsoluteIT.mdf;Integrated Security=True");
        }

    }
}
