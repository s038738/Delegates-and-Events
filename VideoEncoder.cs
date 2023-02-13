using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }


    internal class VideoEncoder
    {
        // Steps :
        // 1- Define a delegate
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);
        // 2- Define an event based on that delegate
        public event VideoEncodedEventHandler VideoEncoded;
        // 3- Raise the event

        // Using Title
        public delegate void VideoEncodedEventHandler1(object source, VideoEventArgs args);
        public event VideoEncodedEventHandler1 VideoEncoded1;


        //Event without delegate
        public event EventHandler<VideoEventArgs> VideoEncoded2;
        public event EventHandler VideoEncoded3;

        public void Encode(Video video)
        {
            Console.WriteLine("(Empty) Encoding Video...");
            Thread.Sleep(3000);
            OnVideoEncoded();
            Console.WriteLine("\n");

            Console.WriteLine("(Delegate) Encoding Video...");
            Thread.Sleep(3000);
            OnVideoEncoded1(video);
            Console.WriteLine("\n");

            Console.WriteLine("(Empty EventHandler) Encoding Video...");
            Thread.Sleep(3000);
            OnVideoEncoded3();
            Console.WriteLine("\n");

            Console.WriteLine("(EventHandler) Encoding Video...");
            Thread.Sleep(3000);
            OnVideoEncoded2(video);
            Console.WriteLine("\n");
        }

        // Simple Event Raise without video title
        protected virtual void OnVideoEncoded()
        {
            if(VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }

        protected virtual void OnVideoEncoded3()
        {
            if (VideoEncoded3 != null)
            {
                VideoEncoded3(this, EventArgs.Empty);
            }
        }

        protected virtual void OnVideoEncoded1(Video video)
        {
            if (VideoEncoded1 != null)
            {
                VideoEncoded1(this, new VideoEventArgs() { Video = video});
            }
        }

        protected virtual void OnVideoEncoded2(Video video)
        {
            if (VideoEncoded2 != null)
            {
                VideoEncoded2(this, new VideoEventArgs() { Video = video });
            }
        }
    }
}
