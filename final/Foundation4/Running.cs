public class Running : Activity
{
    public double _distance;
    public Running(string date, int minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
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
