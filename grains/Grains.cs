using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if(n <=0 || n > 64)
        {
            throw new ArgumentOutOfRangeException();
        }
        if (n == 1)
        {
            return 1UL;
        } 
        return ((ulong)Math.Pow(2, n-1));
    }

    public static ulong Total()
    {
        ulong total = 1UL;
        for(int i = 2; i<=63; i++)
        {
            total += (ulong)Math.Pow(2, i);
        }
        return total;

    }
}