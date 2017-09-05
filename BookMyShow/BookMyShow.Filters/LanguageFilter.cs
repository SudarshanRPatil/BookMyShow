using System;
using System.Collections.Generic;
using System.Linq;
using BookMyShow.Entities;

namespace BookMyShow.Filters
{
    public class LanguageFilter : IFilter
    {
        public List<Show> Filter(List<Show> shows, string value)
        {
            return shows.Where(show => show.Language.Equals(value, StringComparison.CurrentCultureIgnoreCase)).ToList();
        }
    }
}