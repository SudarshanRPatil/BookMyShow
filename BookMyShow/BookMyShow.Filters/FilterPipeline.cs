using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.Filters
{
    public class FilterPipeline<T>
    {
        protected readonly List<IFilter<T>> Filters = new List<IFilter<T>>();

        public FilterPipeline<T> Add(IFilter<T> filter)
        {
            Filters.Add(filter);
            return this;
        }

        public T Execute(T input)
        {
            return Filters.Aggregate(input, (current, filter) => filter.Apply(current));
        }
    }
}
