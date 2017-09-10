using System.Collections.Generic;
using System.Linq;
using BookMyShow.Entities;

namespace BookMyShow.Filters
{
    public class Searcher : ISearch
    {
        public List<Show> Search(SearchCriteria criteria)
        {
            List<Show> shows = new List<Show>();
            if (criteria == null || criteria.Filters.Any() == false)
            {
                return shows;
            }
            FilterPipeline<List<Show>> filterPipeline =  new FilterPipeline<List<Show>>();
            foreach (var filter in criteria.Filters)
            {
                filterPipeline.Add(filter);
            }
            return filterPipeline.Execute(shows);
        }
    }
}