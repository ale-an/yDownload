namespace YDownload
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Введите ссылку на видео");
            var video = Console.ReadLine();

            if (string.IsNullOrEmpty(video))
                return;

            var command = new YouTubeCommand(video);
            var sender = new Sender(command);

            await sender.Description();
            await sender.Download();
        }
    }
}