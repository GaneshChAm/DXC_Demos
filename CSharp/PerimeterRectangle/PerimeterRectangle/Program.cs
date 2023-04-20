namespace PerimeterRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Lengthof the Rectangle");
            decimal x= Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter the Breadth of the Rectangle");
            decimal y = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("The perimeter of the Rectangle is ");
            decimal z = (x + y)*2;
            Console.WriteLine(z);
        }
    }
}