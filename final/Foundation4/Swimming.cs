public class Swimming : Activity
{
    public int _laps;
    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }
    public override double Distance()
    {
        return "something";
    }
    public override double Speed()
    {
        return "something";
    }
    public override double Pace()
    {
        return "something";
    }
}
