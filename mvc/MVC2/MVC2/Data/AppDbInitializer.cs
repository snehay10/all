using MVC2.Data.Enums;
using MVC2.Models;
using static System.Net.WebRequestMethods;

namespace MVC2.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AddDbContext>();
                context.Database.EnsureCreated();

                //cinema
                if (!context.Cinemas.Any())  //if any cinema not present then add this data
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {


                        new Cinema()
                    {
                        Name = "Cinema 1",
                        Logo = "https://www.bing.com/images/search?view=detailV2&ccid=LQOFh5Xr&id=881F0876DE5A6DBE99548001850EF35B85EF13BD&thid=OIP.LQOFh5XrhLTbahzclojz-gHaJ1&mediaurl=https%3a%2f%2fi2.cinestaan.com%2fimage-bank%2f1500-1500%2f28001-29000%2f28441.jpg&exph=1500&expw=1129&q=swarg+movie&simid=608040899985940506&FORM=IRPRST&ck=A61F1BEBE066CDA42CBF4374CE29C469&selectedIndex=0",
                        Description ="This is first cinema"
                    },

                         new Cinema()
                    {
                        Name = "Cinema 2",
                        Logo = "https://www.bing.com/images/search?view=detailV2&ccid=%2fuMoF%2fa%2b&id=824872B6387D04ADC4EB5A57E0C2270FF779E9AF&thid=OIP._uMoF_a-q6yrJovJptgv2gAAAA&mediaurl=https%3a%2f%2fyt3.ggpht.com%2fa%2fAATXAJxtBdSklU_B7ZpMrdeJnFcLP0-DvzO5KMx_iA%253ds900-c-k-c0xffffffff-no-rj-mo&exph=474&expw=474&q=movies+photos&simid=608056258780403369&FORM=IRPRST&ck=28FF0F0E45427A7024C3DB78CB172CA8&selectedIndex=2",
                        Description = "This is second cinema"
                    },

                          new Cinema()

                    {
                        Name = "Cinema 3",
                        Logo = "https://www.bing.com/images/search?view=detailV2&ccid=rG%2bDP8mf&id=77EBFF55712861F6F0110969144ED02D77CB2FBA&thid=OIP.rG-DP8mf9cLDJxw9KTKeRwHaHa&mediaurl=https%3a%2f%2f2.bp.blogspot.com%2f-43VSKfXp3UM%2fUiZQyd4xqjI%2fAAAAAAAAAJw%2f_jpTJqdrWEs%2fs1600%2fripd-2048x2048.jpg&exph=1600&expw=1600&q=movies+photos&simid=608024106681196273&FORM=IRPRST&ck=4A2BBE9D319C2DBC0C55F3A7EACE6107&selectedIndex=5",
                        Description = "This is third cinema"
                    },
                        new Cinema()
                    {
                        Name = "Cinema 4",
                        Logo = "https://www.bing.com/images/search?q=New+Horror+Movies&FORM=IRTRRL",
                        Description = "This is forth cinema"
                    },
                         new Cinema()
                    {
                        Name = "Cinema 5",
                        Logo = "https://www.bing.com/images/search?q=New+Horror+Movies&FORM=IRTRRL",
                        Description = "This is fifth cinema"
                    },

                    });
                    context.SaveChanges();
                }

                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "https://th.bing.com/th?id=OIP.p-aZsNRUiC7FilHb3hnEYgHaE8&w=306&h=204&c=8&rs=1&qlt=90&o=6&pid=3.1&rm=2"

                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://th.bing.com/th?id=OIP.p-aZsNRUiC7FilHb3hnEYgHaE8&w=306&h=204&c=8&rs=1&qlt=90&o=6&pid=3.1&rm=2"
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://th.bing.com/th?id=OIP.p-aZsNRUiC7FilHb3hnEYgHaE8&w=306&h=204&c=8&rs=1&qlt=90&o=6&pid=3.1&rm=2"
                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://th.bing.com/th?id=OIP.p-aZsNRUiC7FilHb3hnEYgHaE8&w=306&h=204&c=8&rs=1&qlt=90&o=6&pid=3.1&rm=2"
                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://th.bing.com/th?id=OIP.p-aZsNRUiC7FilHb3hnEYgHaE8&w=306&h=204&c=8&rs=1&qlt=90&o=6&pid=3.1&rm=2"
                        },
                    });
                    context.SaveChanges();

                }

                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://www.bing.com/ck/a?!&&p=6e7a25fce67811fcJmltdHM9MTY4NTE0NTYwMCZpZ3VpZD0zYjI3MDRlYi1hZjljLTZlNWQtMzlhOS0xN2ZmYWUyZTZmOGYmaW5zaWQ9NTU4MQ&ptn=3&hsh=3&fclid=3b2704eb-af9c-6e5d-39a9-17ffae2e6f8f&u=a1L2ltYWdlcy9zZWFyY2g_cT1rcmlzaG5hIHBpY3MmRk9STT1JUUZSQkEmaWQ9MjE2RkNFQjc0NDA5RjBFRUMwMzY4MDg0OEJFRTY2OEVCQzM3NTVBOA&ntb=1"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://www.bing.com/ck/a?!&&p=6e7a25fce67811fcJmltdHM9MTY4NTE0NTYwMCZpZ3VpZD0zYjI3MDRlYi1hZjljLTZlNWQtMzlhOS0xN2ZmYWUyZTZmOGYmaW5zaWQ9NTU4MQ&ptn=3&hsh=3&fclid=3b2704eb-af9c-6e5d-39a9-17ffae2e6f8f&u=a1L2ltYWdlcy9zZWFyY2g_cT1rcmlzaG5hIHBpY3MmRk9STT1JUUZSQkEmaWQ9MjE2RkNFQjc0NDA5RjBFRUMwMzY4MDg0OEJFRTY2OEVCQzM3NTVBOA&ntb=1"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL =" https://www.bing.com/ck/a?!&&p=6e7a25fce67811fcJmltdHM9MTY4NTE0NTYwMCZpZ3VpZD0zYjI3MDRlYi1hZjljLTZlNWQtMzlhOS0xN2ZmYWUyZTZmOGYmaW5zaWQ9NTU4MQ&ptn=3&hsh=3&fclid=3b2704eb-af9c-6e5d-39a9-17ffae2e6f8f&u=a1L2ltYWdlcy9zZWFyY2g_cT1rcmlzaG5hIHBpY3MmRk9STT1JUUZSQkEmaWQ9MjE2RkNFQjc0NDA5RjBFRUMwMzY4MDg0OEJFRTY2OEVCQzM3NTVBOA&ntb=1"
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL =" https://www.bing.com/ck/a?!&&p=6e7a25fce67811fcJmltdHM9MTY4NTE0NTYwMCZpZ3VpZD0zYjI3MDRlYi1hZjljLTZlNWQtMzlhOS0xN2ZmYWUyZTZmOGYmaW5zaWQ9NTU4MQ&ptn=3&hsh=3&fclid=3b2704eb-af9c-6e5d-39a9-17ffae2e6f8f&u=a1L2ltYWdlcy9zZWFyY2g_cT1rcmlzaG5hIHBpY3MmRk9STT1JUUZSQkEmaWQ9MjE2RkNFQjc0NDA5RjBFRUMwMzY4MDg0OEJFRTY2OEVCQzM3NTVBOA&ntb=1"
                        }
                    });
                    context.SaveChanges();

                }

                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Life",
                            Description = "This is the Life movie description",
                            Price = 39.50,
                            ImageURL = "https://www.bing.com/ck/a?!&&p=6e7a25fce67811fcJmltdHM9MTY4NTE0NTYwMCZpZ3VpZD0zYjI3MDRlYi1hZjljLTZlNWQtMzlhOS0xN2ZmYWUyZTZmOGYmaW5zaWQ9NTU4MQ&ptn=3&hsh=3&fclid=3b2704eb-af9c-6e5d-39a9-17ffae2e6f8f&u=a1L2ltYWdlcy9zZWFyY2g_cT1rcmlzaG5hIHBpY3MmRk9STT1JUUZSQkEmaWQ9MjE2RkNFQjc0NDA5RjBFRUMwMzY4MDg0OEJFRTY2OEVCQzM3NTVBOA&ntb=1",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            movieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            ImageURL = "https://www.bing.com/ck/a?!&&p=6e7a25fce67811fcJmltdHM9MTY4NTE0NTYwMCZpZ3VpZD0zYjI3MDRlYi1hZjljLTZlNWQtMzlhOS0xN2ZmYWUyZTZmOGYmaW5zaWQ9NTU4MQ&ptn=3&hsh=3&fclid=3b2704eb-af9c-6e5d-39a9-17ffae2e6f8f&u=a1L2ltYWdlcy9zZWFyY2g_cT1rcmlzaG5hIHBpY3MmRk9STT1JUUZSQkEmaWQ9MjE2RkNFQjc0NDA5RjBFRUMwMzY4MDg0OEJFRTY2OEVCQzM3NTVBOA&ntb=1",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            movieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Ghost",
                            Description = "This is the Ghost movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            movieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Race",
                            Description = "This is the Race movie description",
                            Price = 39.50,
                            ImageURL = "https://www.bing.com/ck/a?!&&p=6e7a25fce67811fcJmltdHM9MTY4NTE0NTYwMCZpZ3VpZD0zYjI3MDRlYi1hZjljLTZlNWQtMzlhOS0xN2ZmYWUyZTZmOGYmaW5zaWQ9NTU4MQ&ptn=3&hsh=3&fclid=3b2704eb-af9c-6e5d-39a9-17ffae2e6f8f&u=a1L2ltYWdlcy9zZWFyY2g_cT1rcmlzaG5hIHBpY3MmRk9STT1JUUZSQkEmaWQ9MjE2RkNFQjc0NDA5RjBFRUMwMzY4MDg0OEJFRTY2OEVCQzM3NTVBOA&ntb=1",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            movieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 39.50,
                            ImageURL = "https://www.bing.com/ck/a?!&&p=6e7a25fce67811fcJmltdHM9MTY4NTE0NTYwMCZpZ3VpZD0zYjI3MDRlYi1hZjljLTZlNWQtMzlhOS0xN2ZmYWUyZTZmOGYmaW5zaWQ9NTU4MQ&ptn=3&hsh=3&fclid=3b2704eb-af9c-6e5d-39a9-17ffae2e6f8f&u=a1L2ltYWdlcy9zZWFyY2g_cT1rcmlzaG5hIHBpY3MmRk9STT1JUUZSQkEmaWQ9MjE2RkNFQjc0NDA5RjBFRUMwMzY4MDg0OEJFRTY2OEVCQzM3NTVBOA&ntb=1",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            movieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            Price = 39.50,
                            ImageURL = "https://www.bing.com/ck/a?!&&p=6e7a25fce67811fcJmltdHM9MTY4NTE0NTYwMCZpZ3VpZD0zYjI3MDRlYi1hZjljLTZlNWQtMzlhOS0xN2ZmYWUyZTZmOGYmaW5zaWQ9NTU4MQ&ptn=3&hsh=3&fclid=3b2704eb-af9c-6e5d-39a9-17ffae2e6f8f&u=a1L2ltYWdlcy9zZWFyY2g_cT1rcmlzaG5hIHBpY3MmRk9STT1JUUZSQkEmaWQ9MjE2RkNFQjc0NDA5RjBFRUMwMzY4MDg0OEJFRTY2OEVCQzM3NTVBOA&ntb=1",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            movieCategory = MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();

                }

                //Actors and Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },
                          new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 1
                        },
                          new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 2
                        },
                          new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                          new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },
                            new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },
                          new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                     });
                    context.SaveChanges();
                }
           
            }
        }
    }
}
