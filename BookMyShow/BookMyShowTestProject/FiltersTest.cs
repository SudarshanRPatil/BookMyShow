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
                    Language = "English"
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
                    Language = "Hindi"
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
                    Language = "English"
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
                    Language = "Hindi"
                }
            }; 
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            FilterBuilder filterBuilder = FilterBuilder.GetInstance();
            filterBuilder.Register("Language",new LanguageFilter());
            List<Show> filterShows = filterBuilder.Get("Language").Filter(listshows, "hindi");
        }
    }
}
