using System.Reflection.Metadata;

namespace FormatExceptions
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a;
            string line = Console.ReadLine();
            try
            {
                a = int.Parse(line);
               
            }
            catch(FormatException e)
            {
                Console.WriteLine("Zero is not integer not string",line);
            }
            
        }
    }
}
