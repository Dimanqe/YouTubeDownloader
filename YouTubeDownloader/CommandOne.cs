namespace YouTubeDownloader
{
    public class CommandOne : Command
    {
        Receiver receiver;

        public CommandOne(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public override async Task Run()
        {
            Console.WriteLine("Command sent");
            await receiver.GetVideoInfo();
            await receiver.DownloadVideo();
        }

        public override void Stop()
        {
            Console.WriteLine("\nCommand sent");
            receiver.StopDownloading();
        }
    }
}
