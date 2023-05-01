namespace Static_demo
{
    class Demo
    {
        static int num = 0;
        public void Increment()
        {
            num++;
            Console.WriteLine(num);
        }  
        public static void Show()
        {
            Console.WriteLine("This is show method");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo d1 = new Demo();
            Demo d2 = new Demo();
            Demo d3 = new Demo();  
            d1.Increment();
            d2.Increment();
            d3.Increment();

            Demo.Show();
        }
    }
}

//Types of Access Specifier
//1.public  -can access anywhere
//2.private -can access only inside class
//3.internal-can access within the assembly
//4.protected-can access within the class or its dervired class
//5.protected internal-compress the features of protected as well as internal