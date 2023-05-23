namespace Events
{

    public class VideoDecodeEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        /*
         * What is Event ??
         * -- it is a special way to make :
         * -- 1/ loosely coupled classes in my application : اخلي ال classes بتاعتي منفصلة وغير معتمدة
         * -- 2/ make my application more extensable : قابل للزيادة بدون الحاجة للتعديل الكثير
         * 
         * It is very similar to the concept of Broadcasts & Broadcasts Receiver in Android ...
         * When my function in any class is done , I want to do another job or function depend on it.
         * but i want to do this senario with best way , without making my classes tightly coupled
         * 
         * I will do this by sending Events اشعار , to all classes in my application "Publisher"
         * and any class want to listen/observe to this Event should receive it "Receiver/Listener"
         * 
         * What is the way to make Event ??
         *   1- Make a delegate , for publisher class & receiver class too بمعنى شكل موحد للfunction اللي هتنفذ الكور واللي هتبعته
         *   2- Create an Event based on this Delegate , عشان يكون عارف ومميز شكل ال function اللي هتستقبلها 
         *   3- Send/Push/Raise the Event .
         * 
         * 
         * 
         */

        // Delegate : ### FunctionName ### + EventHandler
        public delegate void VideoEncodedEventHandler(object source, EventArgs e);

        // Event : ### FunctionName ### + ed
        public event VideoEncodedEventHandler VideoEncoded;


        // new delegate and event for send arguments
        public delegate void VideoDecodeEventHandler(object source, VideoDecodeEventArgs e);
        public event VideoDecodeEventHandler VideoDecoded;


        // I can make new event without create new delegate for every one
        // by using EventHandler or EventHandler<> for parameters 
        public event EventHandler NoDataReceived;
        public event EventHandler<Video> VideoDataReceived;

        public void Encode(Video video)
        {
            Console.WriteLine("Starting to Encode Video {0} : ", video.Title);
            Thread.Sleep(3000);
            Console.WriteLine("Finishing Encoding Operation :)");

            // After do this code i should raise and push the event
            OnVideoEncoded();
        }

        public void Decode(Video video)
        {
            Console.WriteLine("Starting to Decode Video {0} : ", video.Title);
            Thread.Sleep(3000);
            Console.WriteLine("Finishing Decoding Operation :)");

            OnVideoDecoded(video);
        }

        protected virtual void OnVideoDecoded(Video video)
        {
            VideoDecoded?.Invoke(this, new VideoDecodeEventArgs() { Video = video });
        }

        protected virtual void OnVideoEncoded()
        {
            // check if there are any listeners or receivers for this Event
            VideoEncoded?.Invoke(this, EventArgs.Empty);
        }
    }
}