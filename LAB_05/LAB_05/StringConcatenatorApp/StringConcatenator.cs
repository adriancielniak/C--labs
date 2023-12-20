public class StringConcatenator
{
    public string ConcatenateStrings(string str1, string str2)
    {
        if (str1 == null || str2 == null)
        {
            return null;
        }

        return str1 + str2;
    }
}