using System;
using System.Collections.Generic;
using System.Linq;
using BookMyShow.Entities;

namespace BookMyShow.Filters
{
    public class LanguageFilter : IFilter<List<Show>>
    {
        public string Value { get; set; }

        public List<Show> Apply(List<Show> shows)
        {
            if (shows == null || shows.Any() == false)
            {
                return shows;
            }
            return shows.Where(show => show.Language.Equals(this.Value, StringComparison.CurrentCultureIgnoreCase)).ToList();
        }
    }
}