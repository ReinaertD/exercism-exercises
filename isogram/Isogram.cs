using System;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        string lowercase = word.ToLower();
        for (char c = 'a'; c <= 'z'; c++)
        {
            if(lowercase.IndexOf(c) != lowercase.LastIndexOf(c))
            {
                return false;
            }
        }
        return true;
        throw new NotImplementedException("You need to implement this function.");
    }
}
