using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        // Regex expression would be too long
        if (input.Length < 26)
        {
            return false;
        }
        string lowercase = input.ToLower();
        for(char c='a';c<='z';c++ ) 
        {
            if (lowercase.IndexOf(c) == -1)
            {
                return false;
            } 
        }
        return true;


        throw new NotImplementedException();
    }
}
