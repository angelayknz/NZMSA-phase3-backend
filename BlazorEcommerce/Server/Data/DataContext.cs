using System;
namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Books",
                    Url = "books"
                },
                new Category
                {
                    Id = 2,
                    Name = "Movies",
                    Url = "movies"
                },
                new Category
                {
                    Id = 3,
                    Name = "Video Games",
                    Url = "video-games"
                }
                );


            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Title = "Becoming",
                        Description = "In a life filled with meaning and accomplishment, Michelle Obama has emerged as one of the most iconic and compelling women of our era. As First Lady of the United States of America - the first African American to serve in that role - she helped create the most welcoming and inclusive White House in history while also establishing herself as a powerful advocate for women and girls in the United States and around the world, dramatically changing the ways that families pursue healthier and more active lives and standing with her husband as he led America through some of its most harrowing moments. Along the way, she showed us a few dance moves, crushed Carpool Karaoke, and raised two down-to-earth daughters under an unforgiving media glare. ",
                        ImageUrl = "https://m.media-amazon.com/images/I/41Y1DPGbDvL._SL500_.jpg",
                        Price = 39.99m,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 2,
                        Title = "Can't Hurt Me",
                        Description = "For David Goggins, childhood was a nightmare—poverty, prejudice, and physical abuse colored his days and haunted his nights. But through self-discipline, mental toughness, and hard work, Goggins transformed himself from a depressed, overweight young man with no future into a US Armed Forces icon and one of the world's top endurance athletes. The only man in history to complete elite training as a Navy SEAL, Army Ranger, and Air Force Tactical Air Controller, he went on to set records in numerous endurance events, inspiring Outside magazine to name him The Fittest (Real) Man in America.",
                        ImageUrl = "https://m.media-amazon.com/images/I/51c4H3VBciL._SL500_.jpg",
                        Price = 19.99m,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 3,
                        Title = "Atomic Habits",
                        Description = "In this ground-breaking book, Clear reveals exactly how these minuscule changes can grow into such life-altering outcomes. He uncovers a handful of simple life hacks (the forgotten art of Habit Stacking, the unexpected power of the Two Minute Rule, or the trick to entering the Goldilocks Zone) and delves into cutting-edge psychology and neuroscience to explain why they matter. Along the way, he tells inspiring stories of Olympic gold medalists, leading CEOs and distinguished scientists who have used the science of tiny habits to stay productive, motivated, and happy. ",
                        ImageUrl = "https://m.media-amazon.com/images/I/41wuB-s8vRL._SL500_.jpg",
                        Price = 29.99m,
                        CategoryId = 1
                    }
            );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}

