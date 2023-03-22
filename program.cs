namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Enter is your name:");
            var name = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine()); 
            /* int age1 = Int32.Parse(Console.ReadLine());*/
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);


        }
    }
}
