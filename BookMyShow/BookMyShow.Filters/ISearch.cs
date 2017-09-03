using System.Collections.Generic;
using BookMyShow.Entities;

namespace BookMyShow.Filters
{
    public interface ISearch
    {
        List<Show> Search(SearchCriteria criteria);
    }
}