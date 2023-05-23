using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced
{
    internal class DictGeneric<T, V>
    {
        private readonly Dictionary<T, V> _dict;

        public DictGeneric()
        {
            _dict = new Dictionary<T, V>();
        }

        public void Add(T index , V value)
        {
            _dict.Add( index,value);
        }

        public V this[T index]
        {
            get { return _dict[index]; }
            set { _dict[index] = value; }
        }
    }
}
