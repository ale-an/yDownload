namespace YDownload;

public class Sender
{
    private readonly Command command;

    public Sender(Command command)
    {
        this.command = command;
    }

    public async Task Description()
    {
        await command.Description();
    }

    public async Task Download()
    {
        await command.Download();
    }
}