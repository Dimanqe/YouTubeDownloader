namespace YouTubeDownloader
{
    public abstract class Command
    {
        public abstract Task Run();
        public abstract void Stop();
    }
}
