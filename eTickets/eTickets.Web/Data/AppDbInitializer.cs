using eTickets.Web.Models;
using eTickets.Web.Models.Entities;
using eTickets.Web.Models.Enums;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eTickets.Web.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using var serviceScope = applicationBuilder.ApplicationServices.CreateScope();
            var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
            context.Database.EnsureCreated();

            // Cinema
            if(!context.Cinemas.Any())
            {
                context.Cinemas.AddRange(new List<Cinema>()
                {
                    new Cinema
                    {
                        Name="Cinema 1",
                        Logo="http://dotnethow.net/images/cinemas/cinema-1.jpg",
                        Description="This is the description of the first cinema"
                    },
                    new Cinema
                    {
                        Name="Cinema 2",
                        Logo="http://dotnethow.net/images/cinemas/cinema-2.jpg",
                        Description="This is the description of the second cinema"
                    },
                    new Cinema
                    {
                        Name="Cinema 3",
                        Logo="http://dotnethow.net/images/cinemas/cinema-3.jpg",
                        Description="This is the description of the third cinema"
                    },
                    new Cinema
                    {
                        Name="Cinema 4",
                        Logo="http://dotnethow.net/images/cinemas/cinema-4.jpg",
                        Description="This is the description of the fourth cinema"
                    },
                    new Cinema
                    {
                        Name="Cinema 5",
                        Logo="http://dotnethow.net/images/cinemas/cinema-5.jpg",
                        Description="This is the description of the fifth cinema"
                    }
                });
                context.SaveChanges();
            }

            // Actor

            if (!context.Actors.Any())
            {
                context.Actors.AddRange(new List<Actor>()
                {

                    new Actor
                    {
                        FullName="Actor 1",
                        Bio="This is Bio of the first actor",
                        ProfilePictureUrl="http://dotnethow.net/images/actors/actor-1.jpg"
                    },
                    new Actor
                    {
                        FullName="Actor 2",
                        Bio="This is Bio of the second actor",
                        ProfilePictureUrl="http://dotnethow.net/images/actors/actor-2.jpg"
                    },
                    new Actor
                    {
                        FullName="Actor 3",
                        Bio="This is Bio of the thirth actor",
                        ProfilePictureUrl="http://dotnethow.net/images/actors/actor-3.jpg"
                    },
                    new Actor
                    {
                        FullName="Actor 4",
                        Bio="This is Bio of the fourth actor",
                        ProfilePictureUrl="http://dotnethow.net/images/actors/actor-4.jpg"
                    },
                    new Actor
                    {
                        FullName="Actor 5",
                        Bio="This is Bio of the fifth actor",
                        ProfilePictureUrl="http://dotnethow.net/images/actors/actor-5.jpg"
                    }

                });

                context.SaveChanges();
            }

            // Producer
            if (!context.Producers.Any())
            {
                context.Producers.AddRange(new List<Producer>()
                {
                    new Producer
                    {
                        FullName="Producer 1",
                        Bio="This is the bio of the first producer",
                        ProfilePictureUrl="http://dotnethow.net/images/producers/producer-1.jpg"
                    },
                    new Producer
                    {
                        FullName="Producer 2",
                        Bio="This is the bio of the second producer",
                        ProfilePictureUrl="http://dotnethow.net/images/producers/producer-1.jpg"
                    },
                    new Producer
                    {
                        FullName="Producer 3",
                        Bio="This is the bio of the thirt producer",
                        ProfilePictureUrl="http://dotnethow.net/images/producers/producer-1.jpg"
                    },
                    new Producer
                    {
                        FullName="Producer 4",
                        Bio="This is the bio of the fourth producer",
                        ProfilePictureUrl="http://dotnethow.net/images/producers/producer-1.jpg"
                    },
                    new Producer
                    {
                        FullName="Producer 5",
                        Bio="This is the bio of the fifth producer",
                        ProfilePictureUrl="http://dotnethow.net/images/producers/producer-1.jpg"
                    }
                });
                context.SaveChanges();
            }

            // Movie
            if (!context.Movies.Any())
            {
                context.Movies.AddRange(new List<Movie>()
                {
                    
                    new Movie
                    {
                        Name="Ghost",
                        Description="This is the Ghost description",
                        ImageUrl="http://dotnethow.net/images/movies/movie-4.jpg",
                        StartDate=DateTime.Now,
                        EndDate=DateTime.Now.AddDays(7),
                        CinemaId=4,
                        ProducerId=4,
                        MovieCategory=MovieCategory.Horror
                    },
                    new Movie
                    {
                        Name="Race",
                        Description="This is the Race description",
                        ImageUrl="http://dotnethow.net/images/movies/movie-6.jpg",
                        StartDate=DateTime.Now.AddDays(-10),
                        EndDate=DateTime.Now.AddDays(-5),
                        CinemaId=1,
                        ProducerId=2,
                        MovieCategory=MovieCategory.Documentary
                    },
                    new Movie
                    {
                        Name="Scoob",
                        Description="This is the scoob movie description",
                        ImageUrl="http://dotnethow.net/images/movies/movie-7.jpg",
                        StartDate=DateTime.Now.AddDays(-10),
                        EndDate=DateTime.Now.AddDays(-2),
                        CinemaId=1,
                        ProducerId=3,
                        MovieCategory=MovieCategory.Cartoon
                    },

                    new Movie
                    {
                        Name="Cold Soles",
                        Description="This is the Cold Soles movie description",
                        ImageUrl="http://dotnethow.net/images/movies/movie-8.jpg",
                        StartDate=DateTime.Now.AddDays(3),
                        EndDate=DateTime.Now.AddDays(20),
                        CinemaId=1,
                        ProducerId=5,
                        MovieCategory=MovieCategory.Drama
                    }

                });
                context.SaveChanges();
            }

            // Actor & Movie

            if (!context.Actors_Movies.Any())
            {
                context.Actors_Movies.AddRange(new List<Actor_Movie>()
                {
                    new Actor_Movie
                    {
                        ActorId=1,
                        MovieId=3
                    },
                    new Actor_Movie
                    {
                        ActorId=2,
                        MovieId=3
                    },

                    new Actor_Movie
                    {
                        ActorId=5,
                        MovieId=3
                    },

                    new Actor_Movie
                    {
                        ActorId=2,
                        MovieId=4
                    },

                    new Actor_Movie
                    {
                        ActorId=3,
                        MovieId=4
                    },

                    new Actor_Movie
                    {
                        ActorId=4,
                        MovieId=4
                    }
                   
                });

                context.SaveChanges();
            }

        }
    }
}
