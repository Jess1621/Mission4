using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class MovieApplicationContext : DbContext
    {
        //Constructor
        public MovieApplicationContext (DbContextOptions<MovieApplicationContext> options) : base (options)
        {
            //Leave Blank For Now
        }

        public DbSet<ApplicationResponse> Responses { get; set; }

        // Seeding data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(
                
                new ApplicationResponse
                {
                    ApplicationID = 1,
                    Category = "Action",
                    Title = "Jason Bourne: Bourne Identity",
                    Year = 2002,
                    Director = "Doug Liman",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "Awesome Movie!"
                },

                new ApplicationResponse
                {
                    ApplicationID = 2,
                    Category = "Sports Drama",
                    Title = "Warrior",
                    Year = 2011,
                    Director = "Gavin O'Conner",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "Watch alone, makes me emotional"
                },

                new ApplicationResponse
                {
                    ApplicationID = 3,
                    Category = "Science Fiction",
                    Title = "Dune",
                    Year = 2021,
                    Director = "Denis Villeneuve",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "Super Awesome Movie, should read the book too..."
                }
                
                );
        }
    }
}
