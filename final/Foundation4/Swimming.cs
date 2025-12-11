public class Swimming : Activity
{
    private int _laps;
    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }
    public override double Distance()
    {
        return _laps * 50 / 1000.0 * 0.62;
    }
    public override double Speed()
    {
        return (Distance() / _minutes) * 60;
    }
    public override double Pace()
    {
        return _minutes / Distance();
    }
}
