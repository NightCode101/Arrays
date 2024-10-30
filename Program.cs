using System.IO.Pipes;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Everything with this "//" or "/**/" is a message or instruction

            // Declaring with Values
            // Always start with 0 
            string[] names = { "Jeylo" /* This is 0 */, "Jhunrey" /* This is 1 */, "Christine" /*This is 2 */};
            float[] grades = { 99.2f /* This is 0 */, 95.34f /* This is 1 */, 98.54f /* This is 2*/ };

            //Reading Array Element

            // Names
            Console.WriteLine("Name 1:" + names[0]);
            Console.WriteLine("Name 2:" + names[1]);
            Console.WriteLine("Name 3:" + names[2]);

            // Grades
            Console.WriteLine("Person 1 Garde " + grades[0]);
            Console.WriteLine("Person 2 Garde " + grades[1]);
            Console.WriteLine("Person 3 Garde " + grades[2]);


            // Declaring Without Values
            string[] name = new string[5];
            int[] numbers = new int[15];
            float[] gardes = new float[25];

            // Reading Array Element
            numbers[0] = 12;
            numbers[2] = 75;
            numbers[4] = 32;


            Console.WriteLine("Number : " + numbers[0] + numbers[4]);


            // Assigninng Array Element With User Input
            string[] yourName = new string[3];

            Console.Write("Enter Name 1: ");
            yourName[0] = Console.ReadLine();
            
            Console.Write("Enter Name 2: ");
            yourName[1] = Console.ReadLine();
            
            Console.Write("Enter Name 3: ");
            yourName[2] = Console.ReadLine();

            Console.WriteLine("Name : " + yourName[2]);


            // Here Are The Following When Assigning Array With User Input 

            // Use "num[1] = Console.Readline();" if you use String beacuse Console.ReadLine(); is a string type
            // Use "num[1] = Convert.ToInt32(Console.Readline());" if you use Intiger
            // Use "num[1] = Convert.ToInt64(Console.Readline());" if you use Intiger
            // Use "num[1] = Convert.ToSingle(Console.Readline());" if you use Float
            // Use "num[1] = Convert.ToDouble(Console.Readline());" if you use Double

            


        }
    }
}
