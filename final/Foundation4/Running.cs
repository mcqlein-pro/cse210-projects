using System;

class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _minutes * 60;
    }

    public override double GetPace()
    {
        return _minutes / _distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {_distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
