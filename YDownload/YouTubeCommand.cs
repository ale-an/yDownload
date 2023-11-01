using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos;

namespace YDownload;

public class YouTubeCommand : Command
{
    private string url;

    public YouTubeCommand(string url)
    {
        this.url = url;
    }

    public override async Task Description()
    {
        var videos = new YoutubeClient().Videos;
        var metadata = await videos.GetAsync(url);
        Console.WriteLine(metadata.Description);
    }

    public override async Task Download()
    {
        var videos = new YoutubeClient().Videos;
        await videos.DownloadAsync(url, Path.GetFullPath("C://source//tmp.mp4"),
            builder => builder.SetPreset(ConversionPreset.UltraFast));
    }
}