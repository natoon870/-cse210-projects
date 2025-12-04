public class Cycling : Activity
{
    public double _speed;

    public Cycling(string date, int minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
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
