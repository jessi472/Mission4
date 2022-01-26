//Jessica Kinghorn Mission 4
//Model to seed database and help pass data to database

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class NewMovieContext : DbContext
    {
       public NewMovieContext(DbContextOptions<NewMovieContext> options) : base (options)
        { }
        public DbSet<MovieResponse> Responses { get; set; }

        //Seed 3 Favorite Movies to database
        protected override void OnModelCreating(ModelBuilder mb)
        {mb.Entity<MovieResponse>().HasData(
                new MovieResponse
                {
                    MovieId = 1,
                    Category = "Family",
                    Title = "17 Miracles",
                    Year = 2011,
                    DirectorFirstName = "T.C.",
                    DirectorLastName = "Christensen",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = "The music is great"

                },
                new MovieResponse
                {
                    MovieId = 2,
                    Category = "Family",
                    Title = "Cinderella",
                    Year = 2015,
                    DirectorFirstName = "Kenneth",
                    DirectorLastName = "Branagh",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = "The music is great"


                },
                new MovieResponse
                {
                    MovieId = 3,
                    Category = "Family",
                    Title = "The Man from Snowy River",
                    Year = 1982,
                    DirectorFirstName = "George",
                    DirectorLastName = "Miller",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = "The music is great"


                });
        }

    }
}
