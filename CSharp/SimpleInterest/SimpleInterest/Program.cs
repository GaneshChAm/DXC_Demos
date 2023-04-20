namespace SimpleInterest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Principal Amount");
            decimal num1=Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the rate of interest");
            decimal num2=Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the Time (years)");
            decimal num3=Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("The Simple Interset is ");
            decimal num4=((num1*num2*num3)/100);
            Console.WriteLine(num4);

            Console.WriteLine("Total Amount is ");
            decimal num5 = num4 + num1;
            Console.WriteLine(num5);



        }
    }
}