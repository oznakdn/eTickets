﻿using eTickets.Web.Entities;
using eTickets.Web.Models;
using eTickets.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Web.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Actor_Movie>()
                .HasKey(x => new
                {
                    x.ActorId,
                    x.MovieId
                });
            modelBuilder.Entity<Actor_Movie>().HasOne(x => x.Movie).WithMany(x => x.Actors_Movies)
                .HasForeignKey(x => x.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(x => x.Actor).WithMany(x => x.Actors_Movies)
                .HasForeignKey(x => x.ActorId);


            

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }


    }
}
