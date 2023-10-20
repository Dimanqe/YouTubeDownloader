using System.Text;
using YoutubeExplode;

namespace YouTubeDownloader
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var videoUri = "https://www.youtube.com/watch?v=mf-nC6Z8kLA";
            var client = new YoutubeClient();
            var sender = new Sender();
            var receiver = new Receiver(client, videoUri);
            var commandOne = new CommandOne(receiver);
            sender.SetCommand(commandOne);
            await sender.Run();
            sender.Stop();
        }
    }

}
