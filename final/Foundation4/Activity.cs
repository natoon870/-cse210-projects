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
        return "something";
    }

}