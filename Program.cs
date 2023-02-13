namespace ConsoleApp1
{
    class Program
    {
        static void Main(String[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); // Publisher
            var mailService = new MailService(); // Service
            var messageService = new MessageService(); // Service 2

            // Reference to the method
            videoEncoder.VideoEncoded += mailService.onVideoEncoded;
            videoEncoder.VideoEncoded += messageService.onVideoEncoded;

            videoEncoder.VideoEncoded1 += mailService.onVideoEncoded1;
            videoEncoder.VideoEncoded1 += messageService.onVideoEncoded1;

            videoEncoder.VideoEncoded3 += mailService.onVideoEncoded;
            videoEncoder.VideoEncoded3 += messageService.onVideoEncoded;

            videoEncoder.VideoEncoded2 += mailService.onVideoEncoded1;
            videoEncoder.VideoEncoded2 += messageService.onVideoEncoded1;

            videoEncoder.Encode(video);
        }
    }
}
