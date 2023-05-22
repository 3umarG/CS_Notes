namespace Advanced
{
    public class GenericList<T>
    {
        private List<T> _list;

        public GenericList()
        {
            _list = new List<T>();
        }

        public void Add(T value)
        {
            _list.Add(value);
        }

        public T this[int index]
        {
            get { return _list[index]; }
        }

       
    }
}