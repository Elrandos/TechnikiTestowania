using EFCoreInMemoryDemo.Web.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreInMemoryDemo.Web.Models
{
    public class DataGenerator
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BoardGamesDBContext(
                serviceProvider.GetRequiredService<DbContextOptions<BoardGamesDBContext>>()))
            {
                // Look for any board games already in database.
                if (context.BoardGames.Any())
                {
                    return;   // Database has been seeded
                }

                if (context.Player.Any())
                {
                    return;   // Database has been seeded
                }


                context.BoardGames.AddRange(
                    new BoardGame
                    {
                        ID = 1,
                        Title = "Candy Land",
                        PublishingCompany = "Hasbro",
                        MinPlayers = 2,
                        MaxPlayers = 4,
                        IsReleased = true,
                        ReleaseDate =  DateTime.Now,
                    },
                    new BoardGame
                    {
                        ID = 2,
                        Title = "Sorry!",
                        PublishingCompany = "Hasbro",
                        MinPlayers = 2,
                        MaxPlayers = 4,
                        IsReleased = true,
                        ReleaseDate = DateTime.Now
                    },
                    new BoardGame
                    {
                        ID = 3,
                        Title = "Ticket to Ride",
                        PublishingCompany = "Days of Wonder",
                        MinPlayers = 2,
                        MaxPlayers = 5,
                        IsReleased = false,
                        ReleaseDate = DateTime.Now
                    },
                    new BoardGame
                    {
                        ID = 4,
                        Title = "The Settlers of Catan (Expanded)",
                        PublishingCompany = "Catan Studio",
                        MinPlayers = 2,
                        MaxPlayers = 6,
                        IsReleased = false,
                        ReleaseDate = DateTime.Now
                    },
                    new BoardGame
                    {
                        ID = 5,
                        Title = "Carcasonne",
                        PublishingCompany = "Z-Man Games",
                        MinPlayers = 2,
                        MaxPlayers = 5,
                        IsReleased = true,
                        ReleaseDate = DateTime.Now
                    },
                    new BoardGame
                    {
                        ID = 6,
                        Title = "Sequence",
                        PublishingCompany = "Jax Games",
                        MinPlayers = 2,
                        MaxPlayers = 6,
                        IsReleased = false,
                        ReleaseDate = DateTime.Now
                    });

                context.Player.AddRange(
                    new PlayerModel
                    {
                        ID = 1,
                        FirstName = "Jonny",
                        LastName = "Smith",
                        Age = 25,
                        MemberFrom = DateTime.Now.AddYears(-5),
                        Game = "Sequence"
                    },
                    new PlayerModel
                    {
                        ID = 2,
                        FirstName = "Alex",
                        LastName = "Blackbeard",
                        Age = 45,
                        MemberFrom = DateTime.Now.AddYears(-5),
                        Game = "Sorry!"
                    },
                    new PlayerModel
                    {
                        ID = 3,
                        FirstName = "Chad",
                        LastName = "Wood",
                        Age = 16,
                        MemberFrom = DateTime.Now.AddYears(-5),
                        Game = "Sequence"
                    },
                    new PlayerModel
                    {
                        ID = 4,
                        FirstName = "Tony",
                        LastName = "Windmill",
                        Age = 17,
                        MemberFrom = DateTime.Now.AddYears(-5),
                        Game = "Carcasonne"
                    });

                context.SaveChanges();
            }
        }
    }
}
