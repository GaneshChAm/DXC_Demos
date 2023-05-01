namespace Interface
{
    internal class Program
    {
        //interface IMyInterface
        //{
        //    void Sum(int a,int b);
        //    void Mul (int a,int b);

        //}
        //interface IMyInterface2
        //{
        //    void Squ(int x);
        //    void Cube (int x);
        //}
        //class Demo
        //{
        //    public void Show()
        //    {
        //        Console.WriteLine("This is Show Method");

        //    }
        //}
        //class class1 : Demo, IMyInterface , IMyInterface2
        //{
        //    public void Sum(int a,int b)
        //    {
        //        Console.WriteLine(a+ b);
        //    }
        //    public void Mul(int a,int b)
        //    {
        //        Console.WriteLine(a*b);
        //    }
        //    public void Squ (int x)
        //    {
        //        Console.WriteLine(x*x);
        //    }
        //    public void Cube (int x)
        //    {
        //        Console.WriteLine(x*x*x);
        //    }
        //}

        interface IMyInterface
        {
            void Sum(int a, int b);
            void Mul(int a, int b);

        }
        interface IMyInterface2 : IMyInterface
        {
            void Squ(int x);
            void Cube(int x);
        }
        class class1 : IMyInterface2
        {
            public void Sum(int a, int b)
            {
                Console.WriteLine(a + b);
            }
            public void Mul(int a, int b)
            {
                Console.WriteLine(a * b);
            }
            public void Squ(int x)
            {
                Console.WriteLine(x * x);
            }
            public void Cube(int x)
            {
                Console.WriteLine(x * x * x);
            }
        }

        static void Main(string[] args)
        {
            //class1 obj = new class1();
            //obj.Sum(1, 2);
            IMyInterface obj = new class1();
            obj.Sum(1, 2);
            
        }
    }
}