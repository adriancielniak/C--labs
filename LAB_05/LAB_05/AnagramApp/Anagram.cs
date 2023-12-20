public class AnagramChecker : IAnagramChecker {

    public bool IsAnagram(string word1, string word2)
    {
        if(word1 == null && word2 == null)
        {
            return true;
        }

        if(word1 == null || word2 == null)
        {
            return false;
        }

        word1 = new string(word1.ToLower().Where(c => Char.IsLetter(c)).ToArray());
        word2 = new string(word2.ToLower().Where(c => Char.IsLetter(c)).ToArray());

        if (word1.Length != word2.Length)
        {
            return false;
        }

        char[] charArray1 = word1.ToCharArray();
        char[] charArray2 = word2.ToCharArray();

        Array.Sort(charArray1);
        Array.Sort(charArray2);

        return new string(charArray1) == new string(charArray2);
    }
}