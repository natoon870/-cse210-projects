using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("16 January 2025", 30, 3.0));
        activities.Add(new Cycling("21 March 2025", 45, 12.0));
        activities.Add(new Swimming("09 July 2025", 25, 40));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.Summary());
        }
    }
}
