using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class StoringService
    {
        public void OnVideoEncoded(object source , EventArgs args)
        {
            Console.WriteLine("*********************");
            Console.WriteLine("Received the Event and start Storing to DB Operation ...");
            Console.WriteLine("*********************");
        }
    }
}
