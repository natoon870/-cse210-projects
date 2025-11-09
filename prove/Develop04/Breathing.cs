public class Breathing: Activity
{
    private int _inhale;
    private int _exhale;

    public Breathing(string name, string description)
        : base(name, description)
    {
        _inhale = 4;
        _exhale = 4;
    }

    public void RunBreathing()
    {
        StartingMessage();
        PrepareToBegin();

        int remaining = Duration();
        bool inhaleTurn = true;

        while (remaining > 0)
        {
            if (inhaleTurn)
            {
                int phase = Math.Min(_inhale, remaining);
                Console.Write("\nBreathe in... ");
                Countdown(phase);
                remaining -= phase;
            }
            else
            {
                int phase = Math.Min(_exhale, remaining);
                Console.Write("\nBreathe out... ");
                Countdown(phase);
                remaining -= phase;
            }
            inhaleTurn = !inhaleTurn;
        }

        EndingMessage();
    }
}
