
class NonPlayerCharacter
{
    public string Name { get; set; }
    private NpcDialogPart Dialog;

    public NonPlayerCharacter(string name, NpcDialogPart dialog)
    {
        this.Name = name;
        this.Dialog = dialog;
    }

    public NpcDialogPart StartTalking()
    {
        return Dialog;
    }
}