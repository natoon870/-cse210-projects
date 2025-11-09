public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflection Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("\nSelect a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Breathing breathing = new Breathing(
                    "Breathing",
                    "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathing.RunBreathing();
            }
            else if (choice == "2")
            {
                Reflection reflection = new Reflection(
                    "Reflection",
                    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will" +
                    "hellp your recognize the power you have and how you can use it in other aspects of your life.");
                reflection.RunReflection();
            }
            else if (choice == "3")
            {
                Listing listing = new Listing(
                    "Listing",
                    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listing.RunListing();
            }
            else if (choice == "4")
            {
                Console.WriteLine("\nGoodbye!");
                break;
            }
        }
    }
}
