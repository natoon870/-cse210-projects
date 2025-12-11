class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Boise", "ID", "USA");
        Lecture lecture = new Lecture("Calculus 1 Lecuture", "Learning about Integrals", "09/01/2026", "6:00 PM", address1, "Professor Velsaquez", 25);

        Address address2 = new Address("456 2nd St", "Portland", "OR", "USA");
        Reception reception = new Reception("Wedding Reception", "Wedding Reception for Bob and Sarah", "12/05/2026", "7:00 PM", address2, "wearefinallymarried@gmail.com");

        Address address3 = new Address("Main St", "Rexburg", "ID", "USA");
        OutdoorGathering outdoor = new OutdoorGathering("Party", "93rd Ward, Ward Party", "06/25/2026", "2:00 PM", address3, "Sunny and hot");

    
        Console.WriteLine("LECTURE:");
        Console.WriteLine(lecture.LectureDetails());
        Console.WriteLine(lecture.Description("Lecture"));
        Console.WriteLine();

        Console.WriteLine("RECEPTION:");
        Console.WriteLine(reception.ReceptionDetails());
        Console.WriteLine(reception.Description("Reception"));
        Console.WriteLine();

        Console.WriteLine("OUTDOOR:");
        Console.WriteLine(outdoor.OutdoorDetails());
        Console.WriteLine(outdoor.Description("Outdoor"));
    }
}
