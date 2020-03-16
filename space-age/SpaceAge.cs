using System;

public class SpaceAge
{
    private double Seconds;
    private double TerranYears;

    static double EarthInSeconds = 31557600;
    static double Mercury = 0.2408467;
    static double Venus = 0.61519726;
    static double Mars = 1.8808158;
    static double Jupiter = 11.862615;
    static double Saturn = 29.447498;
    static double Uranus = 84.016846;
    static double Neptune = 164.79132;

    public SpaceAge(int seconds)
    {
        Seconds = seconds;
        TerranYears = Seconds / EarthInSeconds;
    }

    public double OnEarth() => TerranYears;
    public double OnMercury() => TerranYears / Mercury;
    public double OnVenus() => TerranYears / Venus;
    public double OnMars() => TerranYears / Mars;
    public double OnJupiter() => TerranYears / Jupiter;
    public double OnSaturn() => TerranYears / Saturn;
    public double OnUranus() => TerranYears / Uranus;
    public double OnNeptune() => TerranYears / Neptune;
 
}