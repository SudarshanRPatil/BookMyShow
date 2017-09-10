using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.Filters
{
    public sealed class ObjectBuilder<T>
    {
        private ObjectBuilder()
        {
        }

        private Dictionary<string, T> _mapping;

        private static ObjectBuilder<T> _object;
        private static readonly object Lock = new object();
        public static ObjectBuilder<T> GetInstance()
        {
            if (_object == null)
            {

                lock (Lock)
                {
                    if (_object == null)
                        _object = new ObjectBuilder<T>();
                }
            }
            return _object;
        }

        public void Register(string name, T obj)
        {
            if (_mapping == null) _mapping = new Dictionary<string, T>();

            _mapping[GetKey(name)] = obj;
        }

        private string GetKey(string name)
        {
            return name.ToLowerInvariant();
        }
        public T Get(string name)
        {
            if (_mapping.ContainsKey(GetKey(name)))
                return _mapping[GetKey(name)];

            throw new KeyNotFoundException();
        }
    }
}
