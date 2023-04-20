namespace Tempconvert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Temperature in Celsius");
            int num1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Temperature in Fahrenheit");
            int num2 = num1 + 32;
            Console.WriteLine(num2);
        }
    }
}