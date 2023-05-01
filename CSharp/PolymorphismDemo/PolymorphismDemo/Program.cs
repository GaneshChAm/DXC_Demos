namespace PolymorphismDemo
{
    //---------Method Overloading---------------
    //class Demo
    //{
    //    public void Add(int a, int b)
    //    {
    //        Console.WriteLine(a + b);
    //    }
    //    public void Add(int a,int b,int c)
    //    {
    //        Console.WriteLine(a + b + c);
    //    }
    //    public void Add(string a,string b)
    //    {
    //        Console.WriteLine(a + b);
    //    }
    //    public void Add(int a,float b)
    //    {
    //        Console.WriteLine(a + b);
    //    }
    //    public void Add(float x,int y)
    //    {
    //        Console.WriteLine(x + y);
    //    }

    //}
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //       Demo d = new Demo();
    //        d.Add(1,2);
    //        d.Add(3,4,5);
    //        d.Add("hi", "hello");
    //        d.Add(10, 2.5f);
    //        d.Add(3.5f, 20);
    //    }
    //}

    //-----------------Method Overriding-------------
    //class Class1
    //{
    //    public virtual void Print()
    //    {
    //        Console.WriteLine("Welcome");
    //    }
    //    public virtual void Calculator(int x, int y)
    //    {
    //        Console.WriteLine(x+y); 
    //    }

    //}
    //class Class2 : Class1
    //{
    //    public override void Print()
    //    {
    //        Console.WriteLine("Good Morning");
    //    }
    //    public override void Calculator(int x, int y)
    //    {
    //        Console.WriteLine(x * y);
    //    }

    //}
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Class2 c = new Class2();
    //        c.Print();

    //    }
    //}

    //-----------using abstract method overriding
    //abstract class Class1
    //{
    //    public abstract void Add(int x,int y);
    //    public abstract void Sub(int x,int y);

    //}
    //class Class2 : Class1
    //{
    //    public override void Add(int x, int y)
    //    {
    //        Console.WriteLine(x + y);
    //    }
    //    public override void Sub(int x, int y)
    //    {
    //        Console.WriteLine(x - y);
    //    }
    //}
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Class2 c = new Class2();
    //        c.Add(1,2);
    //        c.Sub(2,3);
    //    }
    //}

    //--------------runtime polymorpishm------
    class Person
    {
        public void Show()
        {
            Console.WriteLine("This is Show method of Person class "); 
        }
    }
    class Student : Person
    {
        public void Show()
        {
            Console.WriteLine("This is Show method of Student class ");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Student();
            p.Show();
        }
    }
}