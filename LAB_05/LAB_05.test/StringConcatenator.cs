namespace LAB_05.test;
using NUnit.Framework;

public class StringConcatenatorTest
{
    [Test]
    public void BothNonEmpty()
    {
        StringConcatenator stringConcatenator = new();
        string result = stringConcatenator.ConcatenateStrings("One", "Republic");
        Assert.That(result, Is.EqualTo("OneRepublic"));
    }

    [Test]
    public void FirstIsNull()
    {
        StringConcatenator stringConcatenator = new();
        string result = stringConcatenator.ConcatenateStrings(null, "Republic");
        Assert.That(result, Is.Null);
    }

    [Test]
    public void SecondIsNull()
    {
        StringConcatenator stringConcatenator = new();
        string result = stringConcatenator.ConcatenateStrings("One", null);
        Assert.That(result, Is.Null);
    }

    [Test]
    public void BothAreNull()
    {
        StringConcatenator stringConcatenator = new();
        string result = stringConcatenator.ConcatenateStrings(null, null);
        Assert.That(result, Is.Null);
    }

    [Test]
    public void FirstIsEmpty()
    {
        StringConcatenator stringConcatenator = new();
        string result = stringConcatenator.ConcatenateStrings("", "Republic");
        Assert.That(result, Is.EqualTo("Republic"));
    }

    [Test]
    public void SecondIsEmpty()
    {
        StringConcatenator stringConcatenator = new();
        string result = stringConcatenator.ConcatenateStrings("One", "");
        Assert.That(result, Is.EqualTo("One"));
    }

    [Test]
    public void BothAreEmpty()
    {
        StringConcatenator stringConcatenator = new();
        string result = stringConcatenator.ConcatenateStrings("", "");
        Assert.That(result, Is.EqualTo(""));
    }

    [Test]
    public void WhiteSpaces()
    {
        StringConcatenator stringConcatenator = new();

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
