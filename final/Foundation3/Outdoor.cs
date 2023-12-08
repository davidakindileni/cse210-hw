using System;

public class Outdoor : Event
{

    private string _weather;

    public Outdoor(string title, string description, Address address, string date, string time, string weather) :
    base(title, description, address, date, time)
    {
        this._weather = weather;
    }

    override public string FullDetails()
    {
        string firstPart = base.FullDetails();
        return $"{firstPart}\nWeather Forecast for the day is {this._weather}";

    }

}