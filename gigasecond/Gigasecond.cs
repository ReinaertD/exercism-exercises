using System;

public static class Gigasecond
{
    const double gigasecond = 1e9;
    public static DateTime Add(DateTime moment) => moment.AddSeconds(gigasecond);
}