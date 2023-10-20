using System.Reflection;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace YouTubeDownloader
{
    public class Receiver
    {
        YoutubeClient client;
        string _uri;
        string outputFilePath;
        static Assembly assemblyPath = Assembly.GetExecutingAssembly();
        static string assemblyDir = new FileInfo(assemblyPath.Location).DirectoryName;

        public Receiver(YoutubeClient client, string uri)
        {
            this.client = client;
            _uri = uri;
            outputFilePath = Path.Combine(assemblyDir, @"outputfile.mp4");
        }

        public async Task GetVideoInfo()
        {
            var video = await client.Videos.GetAsync(_uri);

            Console.WriteLine("\nVideo Info:");
            Console.WriteLine("Video Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Duration: " + video.Duration);
        }

        public async Task DownloadVideo()
        {
            Console.Write("\nDownloading started, please wait");      
                        
            await client.Videos.DownloadAsync(_uri, outputFilePath, builder => builder.SetPreset(ConversionPreset.UltraFast));            

            Console.WriteLine("\nVideo downloaded to: " + outputFilePath);  
        }

        public void StopDownloading()
        {
            Thread.Sleep(1000);
            Console.WriteLine("\nDownloading finished");
        }

    }
}
