using System;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        char[] seperated = nucleotide.ToCharArray();
        string transcribed = "";
        foreach(char strand in seperated)
        {
            if(strand == 'G') { transcribed += 'C'; }
            else if (strand == 'C') { transcribed += 'G'; }
            else if (strand == 'T') { transcribed += 'A'; }
            else if (strand == 'A') { transcribed += 'U'; }
        }
        return transcribed;
        throw new NotImplementedException("You need to implement this function.");
    }
}