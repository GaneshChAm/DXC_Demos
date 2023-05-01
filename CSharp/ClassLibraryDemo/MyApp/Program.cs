using MyLibrary;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            Console.WriteLine("Enter the First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Operator");
            char Op = Convert.ToChar(Console.ReadLine());

            switch (Op)
            {
                case '+':
                    {
                        cal.Sum(num1,num2);
                        break;
                    }
                case '-':
                    {
                        cal.Sub(num1,num2);
                        break;
                    }
                case '*':
                    {
                        cal.Mul(num1,num2);
                        break;
                    }
                case '/':
                    {
                        cal.Div(num1,num2);
                        break;  
                    }
                case '%':
                    {
                        cal.Mod(num1,num2);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter the Invalid Operator");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}