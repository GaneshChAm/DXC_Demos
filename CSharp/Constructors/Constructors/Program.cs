//Constructors-a special type of method which will have same name as class.
//Note that the constructor name must match the class name, and it cannot have a return type (like void or int).
//Also note that the constructor is called when the object is created.
namespace Constructors
{
    class Demo
    {
        public Demo()
        {
            Console.WriteLine("I am constructor");
        }
        public Demo(int x)
        {
            Console.WriteLine("This is another constructor");
        }
        public void Show()
        {
            Console.WriteLine("This is show method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            Demo d2 = new Demo(10);
            d.Show();
        }
    }
}