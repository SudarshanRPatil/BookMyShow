using System.Collections.Generic;
using BookMyShow.Entities;

namespace BookMyShow.Filters
{
    public interface IFilter
    {
        List<Show> Filter(List<Show> shows, string value);
    }
}