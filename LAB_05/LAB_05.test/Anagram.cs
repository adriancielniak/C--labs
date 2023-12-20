public class AnagramTest
{
    [Test]
    public void BaseTrueTests()
    {
        AnagramChecker anagramChecker = new();

        Assert.That(anagramChecker.IsAnagram("listen", "silent"), Is.True);
        Assert.That(anagramChecker.IsAnagram("hello", "olelh"), Is.True);
        Assert.That(anagramChecker.IsAnagram("Eleven plus two", "Twelve plus one"), Is.True);
        Assert.That(anagramChecker.IsAnagram("Schoolmaster", "The classroom"), Is.True);
    }

    [Test]
    public void BaseFalseTests()
    {
        AnagramChecker anagramChecker = new();

        Assert.That(anagramChecker.IsAnagram("world", "hello"), Is.False);
        Assert.That(anagramChecker.IsAnagram("Tak to", "tak tak"), Is.False);
        Assert.That(anagramChecker.IsAnagram("abcd", "cba"), Is.False);
        Assert.That(anagramChecker.IsAnagram("takk", "kat"), Is.False);
    }

    [Test]
    public void ComplexTrueTests()
    {
        AnagramChecker anagramChecker = new();

        Assert.That(anagramChecker.IsAnagram("Waitress", "A stew, Sir?"), Is.True);
        Assert.That(anagramChecker.IsAnagram("The centenarians", "I can hear ten \"tens\""), Is.True);
        Assert.That(anagramChecker.IsAnagram("Disraeli", "I lead, Sir"), Is.True);
        Assert.That(anagramChecker.IsAnagram("Heavy Rain?", "Hire a navy!"), Is.True);
    }

    [Test]
    public void ComplexFalseTests()
    {
        AnagramChecker anagramChecker = new();

        Assert.That(anagramChecker.IsAnagram("Waitress", "A stew, Madam?"), Is.False);
        Assert.That(anagramChecker.IsAnagram("The centenarians", "I can't hear ten \"tens\""), Is.False);
        Assert.That(anagramChecker.IsAnagram("Disraeli", "I lead well, Sir"), Is.False);
        Assert.That(anagramChecker.IsAnagram("Heavy Rain?", "Hire a dry van!"), Is.False);
    }

    [Test]
    public void NullTest()
    {
        AnagramChecker anagramChecker = new();

        Assert.That(anagramChecker.IsAnagram(null, null), Is.True);
        Assert.That(anagramChecker.IsAnagram(null, "Not null"), Is.False);
        Assert.That(anagramChecker.IsAnagram("Not null", null), Is.False);
    }
}