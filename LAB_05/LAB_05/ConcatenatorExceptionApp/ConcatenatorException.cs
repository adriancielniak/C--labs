public class ConcatenatorException
{
    public string ConcatenateStrings(string str1, string str2)
    {
        
        if (str1 == null || str2 == null)
        {
            throw new NullReferenceException();
        }

        return str1 + str2;
    }
}