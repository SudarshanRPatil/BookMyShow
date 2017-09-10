using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.Filters
{
    public abstract class Pipeline<T>
    {
        protected readonly List<IFilter> Filters = new List<IFilter>();

        public Pipeline<T> Register(IFilter filter)
        {
            Filters.Add(filter);
            return this;
        }

        public abstract T Process(T input);
    }
}
