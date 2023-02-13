namespace ConsoleApp1
{
    public class MessageService
    {

        public void onVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("MessageServide: Sending a text message...");
        }
        public void onVideoEncoded1(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageServide: Sending a text message..." + args.Video.Title);
        }
    }
}
