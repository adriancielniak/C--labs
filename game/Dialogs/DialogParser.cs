public class DialogParser
{
    Dictionary<string, string> dictionary;

    public DialogParser(Hero hero)
    {
        dictionary = new Dictionary<string, string>
        {
            { "#HERONAME#", hero.Name }
        };
    }

    public string ParseDialog(IDialogPart dialog)
    {
        string result = dialog.GetDialog();

        foreach(var name in dictionary)
        {
            result = result.Replace(name.Key, name.Value);
        }

        return result;
    }
}