
public class ConcatenatorExceptionTest
{
    [Test]
    public void BothNonEmpty()
    {
        ConcatenatorException stringConcatenator = new();
        string result = stringConcatenator.ConcatenateStrings("One", "Republic");
        Assert.That(result, Is.EqualTo("OneRepublic"));
    }

    [Test]
    public void FirstIsNull()
    {
        ConcatenatorException stringConcatenator = new();
        Assert.Throws<NullReferenceException>(() => stringConcatenator.ConcatenateStrings(null, "Republic"));
    }

    [Test]
    public void SecondIsNull()
    {
        ConcatenatorException stringConcatenator = new();
        Assert.Throws<NullReferenceException>(() => stringConcatenator.ConcatenateStrings("One", null));
    }

    [Test]
    public void BothAreNull()
    {
        ConcatenatorException stringConcatenator = new();
        Assert.Throws<NullReferenceException>(() => stringConcatenator.ConcatenateStrings(null, null));
    }

    [Test]
    public void FirstIsEmpty()
    {
        ConcatenatorException stringConcatenator = new();
        string result = stringConcatenator.ConcatenateStrings("", "Republic");
        Assert.That(result, Is.EqualTo("Republic"));
    }

    [Test]
    public void SecondIsEmpty()
    {
        ConcatenatorException stringConcatenator = new();
        string result = stringConcatenator.ConcatenateStrings("One", "");
        Assert.That(result, Is.EqualTo("One"));
    }

    [Test]
    public void BothAreEmpty()
    {
        ConcatenatorException stringConcatenator = new();
        string result = stringConcatenator.ConcatenateStrings("", "");
        Assert.That(result, Is.EqualTo(""));
    }

    [Test]
    public void WhiteSpaces()
    {
        ConcatenatorException stringConcatenator = new();
        string result = stringConcatenator.ConcatenateStrings("One ", "Republic");

        Assert.That(result, Is.EqualTo("One Republic"));

        result = stringConcatenator.ConcatenateStrings("One ", " Republic");
        Assert.That(result, Is.EqualTo("One  Republic"));

        result = stringConcatenator.ConcatenateStrings(" One", "Republic");
        Assert.That(result, Is.EqualTo(" OneRepublic"));

        result = stringConcatenator.ConcatenateStrings("One", "Republic ");
        Assert.That(result, Is.EqualTo("OneRepublic "));

        result = stringConcatenator.ConcatenateStrings(" One ", " Republic");
        Assert.That(result, Is.EqualTo(" One  Republic"));
    }
}