using System;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if(number <= 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        int Sum = 0;
        
        for(int i = 1; i<number; i++)
        {
            if(number % i == 0)
            {
                Sum += i;
            }
        }
        if (Sum >= number)
        {
            return Sum == number ? Classification.Perfect : Classification.Abundant;
        }
        else return  Classification.Deficient;
    }
}
