using System;

public static class ResistorColor
{
    //static string[] resistors = new string[10] { "black", "brown", "red", "orange", "yellow", "green","blue","violet","grey","white"};

    private enum resistors : int
    {
        black = 0,
        brown = 1,
        red = 2,
        orange = 3,
        yellow = 4,
        green = 5,
        blue = 6,
        violet = 7,
        grey = 8,
        white = 9
    }
    public static int ColorCode(string color) =>(int)Enum.Parse(typeof(resistors), color); 

    public static string[] Colors() => Enum.GetNames(typeof(resistors));
}
