namespace MyLibrary
{
    public class Calculator
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine("Addition of Two numbers is :" + (a+ b));
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine("Subtraction of Two numbers is :" + (a -b));
        }
        public void Mul(int a, int b)
        {
            Console.WriteLine("Multiplication of Two numbers is :" + (a *b));
        }
        public void Div(int a, int b)
        { 
            Console.WriteLine("Division of Two numbers is :" + (a /b));
        }
        public void Mod(int a, int b)
        {
            Console.WriteLine("Mod Division of Two numbers is :" + (a %b)); 
        }

    }
}