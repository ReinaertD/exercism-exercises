using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        if(number <= 0)
        {
            throw new ArgumentException();
        }
        
        int steps = 0;
        while (number!=1)
        {
            if (number % 2 == 0)
            {
            steps++;
            number /= 2;
            }
             
            if(number %2 != 0 && number != 1)
            {
                steps++;
                number = (number*3)+1;
            }  
        }
        return steps;
    }
}