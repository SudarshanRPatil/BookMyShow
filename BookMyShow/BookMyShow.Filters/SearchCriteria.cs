using BookMyShow.Entities;
using System.Collections.Generic;

namespace BookMyShow.Filters
{
    public class SearchCriteria
    {
        public List<IFilter<List<Show>>> Filters { get; set; }
    }
}