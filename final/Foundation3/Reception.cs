public class Reception : Event
{
        private string _rsvpEmail;
    public Reception(string title, string description, string date, string time,
                     Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }
    public string ReceptionDetails()
{
    return
        $"{StandardDetails()}\n" +
        $"Type: Reception\n" +
        $"RSVP Email: {_rsvpEmail}";
}
}