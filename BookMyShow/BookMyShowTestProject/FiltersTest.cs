using System;
using System.Collections.Generic;
using BookMyShow.Entities;
using BookMyShow.Filters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookMyShowTestProject
{
    [TestClass]
    public class FiltersTest
    {
        #region create listshows
        List<Show> listshows = new List<Show>
            {
                new MovieShow()
                {
                    MovieId = 01,
                    Duration = new Duration()
                    {
                        StartTime = new DateTime(2017, 12, 12, 09, 00, 00),
                        EndTime = new DateTime(2017, 12, 12, 12, 00, 00)
                    },
                    AuditoriumId = 01,
                    TheatreId = "BOllyWood",
                    Interval = new Duration()
                    {
                        StartTime = new DateTime(2017, 12, 12, 10, 20, 00),
                        EndTime = new DateTime(2017, 12, 12, 10, 40, 00)
                    },
                    Rates = new List<SeatInfo>()
                    {
                        new SeatInfo()
                        {
                            Price = new Money() {Amount = 150, Currency = "INR"},
                            SeatClass = SeatClass.Silver
                        },
                        new SeatInfo()
                        {
                            Price = new Money() {Amount = 180, Currency = "INR"},
                            SeatClass = SeatClass.Gold
                        },
                        new SeatInfo()
                        {
                            Price = new Money() {Amount = 230, Currency = "INR"},
                            SeatClass = SeatClass.Platinum
                        }
                    },
                    Language = "Hindi"
                },
                new MovieShow()
                {
                    MovieId = 02,
                    Duration = new Duration()
                    {
                        StartTime = new DateTime(2017, 12, 12, 10, 00, 00),
                        EndTime = new DateTime(2017, 12, 12, 13, 00, 00)
                    },
                    AuditoriumId = 02,
                    TheatreId = "BOllyWood",
                    Interval = new Duration()
                    {
                        StartTime = new DateTime(2017, 12, 12, 11, 20, 00),
                        EndTime = new DateTime(2017, 12, 12, 11, 40, 00)
                    },
                    Rates = new List<SeatInfo>()
                    {
                        new SeatInfo()
                        {
                            Price = new Money() {Amount = 120, Currency = "INR"},
                            SeatClass = SeatClass.Silver
                        },
                        new SeatInfo()
                        {
                            Price = new Money() {Amount = 150, Currency = "INR"},
                            SeatClass = SeatClass.Gold
                        },
                        new SeatInfo()
                        {
                            Price = new Money() {Amount = 200, Currency = "INR"},
                            SeatClass = SeatClass.Platinum
                        }
                    },
                    Language = "English"
                },
                new MovieShow()
                {
                    MovieId = 03,
                    Duration = new Duration()
                    {
                        StartTime = new DateTime(2017, 12, 12, 12, 00, 00),
                        EndTime = new DateTime(2017, 12, 12, 15, 00, 00)
                    },
                    AuditoriumId = 01,
                    TheatreId = "PVR-Inorbit",
                    Interval = new Duration()
                    {
                        StartTime = new DateTime(2017, 12, 12, 13, 20, 00),
                        EndTime = new DateTime(2017, 12, 12, 13, 40, 00)
                    },
                    Rates = new List<SeatInfo>()
                    {
                        new SeatInfo()
                        {
                            Price = new Money() {Amount = 180, Currency = "INR"},
                            SeatClass = SeatClass.Silver
                        },
                        new SeatInfo()
                        {
                            Price = new Money() {Amount = 200, Currency = "INR"},
                            SeatClass = SeatClass.Gold
                        },
                        new SeatInfo()
                        {
                            Price = new Money() {Amount = 250, Currency = "INR"},
                            SeatClass = SeatClass.Platinum
                        }
                    },
                    Language = "Hindi"
                },
                new MovieShow()
                {
                    MovieId = 02,
                    Duration = new Duration()
                    {
                        StartTime = new DateTime(2017, 12, 12, 09, 00, 00),
                        EndTime = new DateTime(2017, 12, 12, 12, 00, 00)
                    },
                    AuditoriumId = 01,
                    TheatreId = "PVR-Inorbit",
                    Interval = new Duration()
                    {
                        StartTime = new DateTime(2017, 12, 12, 10, 20, 00),
                        EndTime = new DateTime(2017, 12, 12, 10, 40, 00)
                    },
                    Rates = new List<SeatInfo>()
                    {
                        new SeatInfo()
                        {
                            Price = new Money() {Amount = 150, Currency = "INR"},
                            SeatClass = SeatClass.Silver
                        },
                        new SeatInfo()
                        {
                            Price = new Money() {Amount = 180, Currency = "INR"},
                            SeatClass = SeatClass.Gold
                        },
                        new SeatInfo()
                        {
                            Price = new Money() {Amount = 230, Currency = "INR"},
                            SeatClass = SeatClass.Platinum
                        }
                    },
                    Language = "English"
                }
            };
        #endregion

        #region create listMovies

        #region Movie1
        Movie movie1 = new Movie()
        {
            Cast = new MovieCast()
            {
                Actors = new List<Actor>()
            {
                new Actor() {FirstName = "Sidharth",LastName = "Malhotra"},
                new Actor() {FirstName = "Varun", LastName = "Dhawan"},
                new Actor() {FirstName = "Alia", LastName = "Bhatt"}
            }
            },
            Certificate = new MovieCertificate() { CensorRating = CensorRating.UA },
            Crew = new MovieCrew()
            {
                Directors = new List<Director> { new Director() { FirstName = "Karan", LastName = "Johar" } },
                Producers = new List<Producer>() { new Producer() { FirstName = "Yash", LastName = "Johar" } }
            },
            DurationInMinutes = 160,
            Genre = Genre.Drama,
            Id = 01,
            Languages = new List<string>() { "Hindi" },
            Name = "Student of the year",
            Summary = "Student of the Year is a 2012 Indian romantic comedy-drama film directed by Karan Johar and produced by Hiroo Yash Johar under the banner of Dharma Productions and in collaboration with Shah Rukh Khan's Red Chillies Entertainment.The movie features newcomers Sidharth Malhotra, Varun Dhawan and Alia Bhatt in the lead roles.This is Karan Johar's first-and-only directorial venture without Shah Rukh Khan."
        };
        #endregion

        #region Movie2
        Movie movie2 = new Movie()
        {
            Cast = new MovieCast()
            {
                Actors = new List<Actor>()
                {
                    new Actor() {FirstName = "Christian",LastName = "Bale"},
                    new Actor() {FirstName = "Michael", LastName = "Caine"},
                    new Actor() {FirstName = "Liam", LastName = "Neeson"},
                    new Actor() {FirstName = "Katie", LastName = "Holmes"}
                }
            },
            Certificate = new MovieCertificate() { CensorRating = CensorRating.UA },
            Crew = new MovieCrew()
            {
                Directors = new List<Director> { new Director() { FirstName = "Christopher", LastName = "Nolan" } },
                Producers = new List<Producer>()
                {
                    new Producer() { FirstName = "Emma", LastName = "Thomas" },
                    new Producer() { FirstName = "Larry", LastName = "Franco"},
                    new Producer() { FirstName = "Charles", LastName = "Roven"}
                }
            },
            DurationInMinutes = 160,
            Genre = Genre.Action,
            Id = 03,
            Languages = new List<string>() { "Hindi", "English" },
            Name = "Batman Begins",
            Summary = "Batman Begins is a 2005 superhero film based on the DC Comics character Batman, co-written and directed by Christopher Nolan and starring Christian Bale, Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman, Cillian Murphy, Tom Wilkinson, Rutger Hauer, Ken Watanabe and Morgan Freeman."
        };
        #endregion

        #region Movie3
        Movie movie3 = new Movie()
        {
            Cast = new MovieCast()
            {
                Actors = new List<Actor>()
                {
                    new Actor() {FirstName = "Prabhas",LastName = string.Empty},
                    new Actor() {FirstName = "Rana", LastName = "Daggubati"},
                    new Actor() {FirstName = "Anushka", LastName = "Shetty"},
                    new Actor() {FirstName = "Tamannaah", LastName = string.Empty}
                }
            },
            Certificate = new MovieCertificate() { CensorRating = CensorRating.UA },
            Crew = new MovieCrew()
            {
                Directors = new List<Director> { new Director() { FirstName = "S.S.", LastName = "Rajamouli" } },
                Producers = new List<Producer>()
                {
                    new Producer() { FirstName = "Shobu", LastName = "Yarlangadda" },
                    new Producer() { FirstName = "Prasad", LastName = "Devnineni"}
                }
            },
            DurationInMinutes = 160,
            Genre = Genre.Action,
            Id = 03,
            Languages = new List<string>() { "Hindi", "English", "Tamil", "Telgu" },
            Name = "Baahubali: The Beginning",
            Summary = "Baahubali: The Beginning(stylized as bãhubali; English: The One with Strong Arms: The Beginning), also known by the initialism BBTB, is an Indian epic historical fiction film directed by S.S.Rajamouli.The film was produced by Shobu Yarlagadda and Prasad Devineni and was shot as a bilingual in Telugu and Tamil."
        }; 
        #endregion

        #endregion

        [TestMethod]
        public void TestFilterMethod()
        {
            List<Movie> movies = new List<Movie>();
            movies.Add(movie1);
            movies.Add(movie2);
            movies.Add(movie3);

            ObjectBuilder<IFilter<List<Show>>> filterBuilder = ObjectBuilder<IFilter<List<Show>>>.GetInstance();
            filterBuilder.Register("Language",new LanguageFilter());
            List<Show> filterShows = filterBuilder.Get("Language").Apply(listshows);
            foreach (var filterShow in filterShows)
            {
                Assert.AreEqual(filterShow.Language.ToLower(), "hindi");
            }
        }
    }
}
