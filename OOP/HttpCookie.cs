using System.Runtime.CompilerServices;

namespace OOP
{
    class HttpCookie
    {
        /*
         * I want to implement Indexer Mechanism 
         * such as cookie['name'],  cookie['contentType']
         * I want to implement that mechanism from scratch
         */

        private readonly Dictionary<string, string> _cookies;
        public HttpCookie()
        {
            _cookies = new Dictionary<string, string>();
        }

        public string? this[string key]
        {
            get
            {
                try
                {
                    return _cookies[key];
                }
                catch (KeyNotFoundException)
                {
                    return null;
                }
            }
            set { _cookies[key] = value!; }
        }


    }
}