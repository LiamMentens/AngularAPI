﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularAPI.Models
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Gebruiker> Gebruikers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Lijst> Lijsten { get; set; }
        public DbSet<Stem> Stemmen { get; set; }
        //public DbSet<LijstGebruiker> LijstGebruiker { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gebruiker>().ToTable("Gebruiker");
            modelBuilder.Entity<Item>().ToTable("Item");
            modelBuilder.Entity<Lijst>().ToTable("Lijst");
            modelBuilder.Entity<Stem>().ToTable("Stem");
            //modelBuilder.Entity<LijstGebruiker>().ToTable("LijstGebruiker");
        }
    }
}
