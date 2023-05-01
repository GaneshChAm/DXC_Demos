namespace InheritanceDemo
{
    class Calculator
    {
        internal string name;
        public Calculator() 
        {
            Console.WriteLine("This is Calculator");
        } 
        public Calculator(int x) 
        {
            Console.WriteLine("This is another Calculator");
        }
        public int sum(int a,int b)
        {
            return a + b;
        }
        public int sub(int a,int b)
        {
            return a - b;
        }
        public int mul(int a,int b)
        {
            return (a * b);
        }
        public void Show()
        {
            Console.WriteLine("This is Show method");
        }
    }
    class ScientificCalculator : Calculator
    {
        public ScientificCalculator() : base(10)
        {
            //base.sum(1, 2);
            name = "john";
            Console.WriteLine("This is Scientific Calculator");
        }
        public new void Show()
        {
            Console.WriteLine("This is Show method");
        }
        public int square(int x)
        {
            return x * x;
        }
        public int cube(int x)
        {
            return x * x * x;
        }
        public int fact(int x)
        {
            int fact = 1;
            for (int i= 1; i<= x; i++)
            { 
                fact = fact * i;
            }
            return fact;
        }
    }
    class AIcalculator : ScientificCalculator
    {
        public AIcalculator() 
        {
            Console.WriteLine("This is AI Calculator");
        }
        public void message()
        {
            Console.WriteLine("Welcome to AI Calculator");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            AIcalculator cal = new AIcalculator();
           
        }
    }
}