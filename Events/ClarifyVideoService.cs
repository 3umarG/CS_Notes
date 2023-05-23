using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class ClarifyVideoService
    {
        public void OnVideoDecoded(object source, VideoDecodeEventArgs e)
        {
            Console.WriteLine("*********************");
            Console.WriteLine("Received the Event and start all processes in the video with title : {0} ...", e.Video.Title);
            Console.WriteLine("*********************");
        }
    }
}
