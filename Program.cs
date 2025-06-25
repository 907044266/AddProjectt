

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask for name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // Ask for date of birth
            Console.Write("Enter your date of birth (e.g. 2004-06-25): ");
            string dob = Console.ReadLine();

            // Ask for address
            Console.Write("Enter your address: ");
            string address = Console.ReadLine();

            // Show output
            Console.WriteLine("\n--- Your Information ---");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Date of Birth: {dob}");
            Console.WriteLine($"Address: {address}");

            // Pause the console
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}