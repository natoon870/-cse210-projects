public abstract class Activity
{
    public string _date;
    public int _minutes;

    protected Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public abstract double Distance();
    public abstract double Speed();
    public abstract double Pace();

    public virtual string Summary()
    {
        return $"{_date} {GetType().Name} ({_minutes} min)- " +
               $"Distance {Distance():0.0} miles, " +
               $"Speed {Speed():0.0} mph, " +
               $"Pace {Pace():0.0} min per mile";
    }
}
