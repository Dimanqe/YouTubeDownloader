namespace YouTubeDownloader
{
    public class Sender
    {
        Command _command;

        public void SetCommand(Command command)
        {
            _command = command;
        }

        public async Task Run()
        {
            await _command.Run();
        }
        public void Stop()
        {
            _command.Stop();
        }
    }
}
