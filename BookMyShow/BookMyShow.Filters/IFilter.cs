using System.Collections.Generic;
using BookMyShow.Entities;

namespace BookMyShow.Filters
{
    public interface IFilter<T>
    {
        string Value { get; set; }

        T Apply(T shows);
    }
}