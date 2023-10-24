public interface IDialogPart
{
    string GetDialog();
}

public class HeroDialogPart: IDialogPart
{
    private string Text;

    public NpcDialogPart Response { get; set;}

    public HeroDialogPart(string text, NpcDialogPart response )
    {
        this.Text = text;
        this.Response = response;
    }

    public string GetDialog()
    {
        return Text;
    }
}

public class NpcDialogPart : IDialogPart
{ 
    private string Text;

    public HeroDialogPart [] Responses { get; set; }

    public NpcDialogPart(string text, HeroDialogPart [] responses)
    {
        this.Text = text;
        this.Responses = responses;
    }

    public string GetDialog()
    {
        return Text;
    }
}