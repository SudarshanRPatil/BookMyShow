using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.Filters
{
    public sealed class FilterBuilder
    {
        private FilterBuilder()
        {
        }

        private Dictionary<string, IFilter> _mapping;

        private static FilterBuilder _object;
        private static readonly object Lock = new object();
        public static FilterBuilder GetInstance()
        {
            if (_object == null)
            {

                lock (Lock)
                {
                    if (_object == null)
                        _object = new FilterBuilder();
                }
            }
            return _object;
        }

        public void Register(string name, IFilter filter)
        {
            if (_mapping == null) _mapping = new Dictionary<string, IFilter>();

            _mapping[GetKey(name)] = filter;
        }

        private string GetKey(string name)
        {
            return name.ToLowerInvariant();
        }
        public IFilter Get(string name)
        {
            if (_mapping.ContainsKey(GetKey(name)))
                return _mapping[GetKey(name)];

            throw new KeyNotFoundException();
        }
    }
}
