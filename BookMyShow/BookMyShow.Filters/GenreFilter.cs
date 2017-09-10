using BookMyShow.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.Filters
{
    public class GenreFilter : IFilter<List<Show>>
    {
        public string Value { get; set; }
        public List<Show> Apply(List<Show> shows)
        {
            throw new NotImplementedException();
        }
    }
}
