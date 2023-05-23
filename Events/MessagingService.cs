using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{

    // This the receiver class 
    // should have On##### function with the same delegate I have created on the Publisher class
    internal class MessagingService
    {
        public void OnVideoEncoded(object source , EventArgs args)
        {
            Console.WriteLine("*********************");
            Console.WriteLine("Received the Event and start Messaging Operation ...");
            Console.WriteLine("*********************");
        }
    }
}
