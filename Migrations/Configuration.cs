namespace MvcMovie.Migrations
{
    using MvcMovie.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMovie.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcMovie.Models.MovieDBContext context)
        {
            context.Movies.AddOrUpdate(i => i.Title,
                new Movie
                {
                    Title = "When Sally Killed Harry",
                    ReleaseDate = DateTime.Parse("1989-1-11"),
                    Genre = "Romantic Horror",
                    Rating = "XXX",
                    Price = 7.99M
                },

                 new Movie
                 {
                     Title = "Dishbusters ",
                     ReleaseDate = DateTime.Parse("1984-3-13"),
                     Genre = "Drama",
                     Rating = "XXX",
                     Price = 8.99M
                 },

                 new Movie
                 {
                     Title = "Dishbusters 2",
                     ReleaseDate = DateTime.Parse("1986-2-23"),
                     Genre = "Romantic Horror",
                     Rating = "XXX",
                     Price = 9.99M
                 },

               new Movie
               {
                   Title = "220 A Space Oddity",
                   ReleaseDate = DateTime.Parse("1959-4-15"),
                   Genre = "Documentary",
                   Rating = "XXX",
                   Price = 3.99M
               }
           );

        }
    }
}
