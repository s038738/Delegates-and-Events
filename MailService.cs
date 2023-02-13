namespace ConsoleApp1
{
    public class MailService
    {
        public void onVideoEncoded(object source, EventArgs e)
        {
            // Simulation to write an email
            Console.WriteLine("MailService: Sending an email...");
        }
        public void onVideoEncoded1(object source, VideoEventArgs e)
        {
            // Simulation to write an email
            Console.WriteLine("MailService: Sending an email..." + e.Video.Title);
        }
    }
}
