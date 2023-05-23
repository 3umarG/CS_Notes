namespace Events
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("***** Hello for Events and Delegate *****");

            var videoEncoder = new VideoEncoder(); // publisher
            var messageService = new MessagingService(); // subscriber
            var dbService = new StoringService(); // new subscriber

            // link between publisher and subscriber by using delegate تعارف 
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.VideoEncoded += dbService.OnVideoEncoded;

            // start my function from publisher and wait until it finished and the subscriber do its job
            videoEncoder.Encode(new Video() { Title = "First Video" });



            // subscriber for receiving message for publisher
            var clarifyService = new ClarifyVideoService();

            // linke between pub. and subscriber
            videoEncoder.VideoDecoded += clarifyService.OnVideoDecoded;

            videoEncoder.Decode(new Video() { Title = "- Video for Decode -"});

            
            
        }

        private static void VideoEncoder_VideoDecoded(object source, VideoDecodeEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}