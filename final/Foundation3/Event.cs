public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public string StandardDetails()
    {
        return 
            $"Title: {_title}\n" +
            $"Description: {_description}\n" +
            $"Date: {_date}\n" +
            $"Time: {_time}\n" +
            $"Location:\n{_address.FullAddress()}";
    }
    public string Description(string typeName)
    {
        return $"{typeName} | {_title} | {_date}";
    }
}