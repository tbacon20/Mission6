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

        // Create the second db set of all the movie categories
        public DbSet<Category> Categories { get; set; }
    
        // Seeding the db upon creation
        // Protected = if it's being inherrited it's okay to run
        // Override will override a method in the db context
        protected override void OnModelCreating(ModelBuilder mb)
        {
            // Seed the data for the categorites
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Science Fiction" },
                new Category { CategoryId = 2, CategoryName = "Action" },
                new Category { CategoryId = 3, CategoryName = "Drama" },
                new Category { CategoryId = 4, CategoryName = "Romance" },
                new Category { CategoryId = 5, CategoryName = "Comedy" },
                new Category { CategoryId = 6, CategoryName = "Documentary" },
                new Category { CategoryId = 7, CategoryName = "Horror" },
                new Category { CategoryId = 8, CategoryName = "Thriller" },
                new Category { CategoryId = 9, CategoryName = "Adventure" }
            );

            // Seed the data for the responses
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    ApplicationId = 1,
                    CategoryId = 1,
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
                    CategoryId = 2,
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
                    CategoryId = 1,
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
