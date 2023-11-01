namespace YDownload;

public abstract class Command
{
    public abstract Task Description();
    public abstract Task Download();
}