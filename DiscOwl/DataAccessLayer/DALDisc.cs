using DiscOwl.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DiscOwl.DataAccessLayer
{
    public class DALDisc : DbContext
    {
        public DbSet<Performer> PerformerDbSet { get; set; }
        public DbSet<Models.Type> TypeDbSet { get; set; }
        public DbSet<Disc> DiscDbSet { get; set; }
        public DbSet<DiscType> DiscTypeDbSet { get; set; }
        public DbSet<Customer> CustomerDbSet { get; set; }
        public DbSet<Score> ScoreDbSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Performer>().ToTable("Interprete");
            modelBuilder.Entity<Models.Type>().ToTable("Tipo");
            modelBuilder.Entity<Disc>().ToTable("Disco");
            modelBuilder.Entity<DiscType>().ToTable("DiscoTipo");
            modelBuilder.Entity<Customer>().ToTable("Cliente");
            modelBuilder.Entity<Score>().ToTable("Puntuacion");

            base.OnModelCreating(modelBuilder);
        }
    }
}