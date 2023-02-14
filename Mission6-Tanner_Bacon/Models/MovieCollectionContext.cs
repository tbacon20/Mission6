using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_Tanner_Bacon.Models
{
    // Inheriting from DbContext using Microsoft.EntityFrameworkCore;
    public class MovieCollectionContext : DbContext
    {
        // Contructor for this class. Params = Constructor of type "MovieCollectionContext" called options that inherit from the base dbcontext options
        public MovieCollectionContext(DbContextOptions<MovieCollectionContext> options) : base (options)
        {

        }

        // Create a set of data in our database called responses (This is all the variables we're getting from the form)
        // Application response is the name of the opject we create in ApplicationResponse.cs
        public DbSet<ApplicationResponse> Responses { get; set; }
    
        // Seeding the db upon creation
        // Protected = if it's being inherrited it's okay to run
        // Override will override a method in the db context
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    ApplicationId = 1,
                    Category = "Science Fiction",
                    Title = "Interstellar",
                    Year = 2014,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = "",
                    Lent = "",
                    Notes = ""
                },
                new ApplicationResponse
                {
                    ApplicationId = 2,
                    Category = "Action",
                    Title = "Tenet",
                    Year = 2020,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = "",
                    Lent = "",
                    Notes = ""
                },
                new ApplicationResponse
                {
                    ApplicationId = 3,
                    Category = "Science Fiction",
                    Title = "Inception",
                    Year = 2010,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = "",
                    Lent = "",
                    Notes = ""
                }
            );
        }
    }
}
