using System;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string[] seperated = phrase.Split(new char[] { ' ', '-', '.', '_' }, StringSplitOptions.RemoveEmptyEntries) ;
        string acronym = "";
        foreach(string word in seperated)
        {
            acronym += word[0];
        }
        acronym = acronym.ToUpper();
        return acronym;
    }
}