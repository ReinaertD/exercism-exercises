using System;
using System.Linq;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        if(input == String.Empty)
        {
            return "";
        }
        char[] seperated = input.ToCharArray();
        char[] reversed = seperated.Reverse().ToArray();
        string sol = new string(reversed);
        return sol;
        throw new NotImplementedException("You need to implement this function.");
    }
}