using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        if (year % 4 == 0) {
            //if (year % 100 == 0 && year % 400 != 0)
            //{
            //    return false;
            //}
            //return true;
            // VS gave me the simplified if statement, unfortunately didn't come up with it on my own.
            return year % 100 != 0 || year % 400 == 0;
        }
        return false;
    }
}