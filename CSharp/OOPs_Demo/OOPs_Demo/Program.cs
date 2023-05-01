//OBJECT ORIENTED PROGRAMMING (OOP)
//----Advanatages of OOPs:-
//-Relates to real world situations.
//-Flexibility to change.
//-Modularity.(parts into single unit)
//-Easy to debug...........

//----Features of OOPs:-
//1.Encapsulation-process of wrapping or binding data into a single unit(class).{data hiding}
//2.Abstraction-process of abstract the necessary details.
//3.Polymorpishm-multiple shapes for a single object.
//4.Inheritance-inheritating the class from other(parent)class.

//------Types of Inheritance:-
//1.Single-level
//2.Multi-level
//3.Multiple(Not supported in C#)
//4.Hybrid
//5.Hierarchical

namespace OOPs_Demo
{
    class Calculator
    {
        public void Show()
        {
            Console.WriteLine("This is Show method");
        }

        public void Sayhello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        public void Sum(int a, int b)
        {
            Console.WriteLine(a+b);    
        }

        public int Cube(int x)
        { 
            return x*x*x;
        }

        public void Add(int a, int b = 0, int c = 0)
        {
            Console.WriteLine(a+b+c);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.Show();
            c.Sayhello("john");
            c.Sayhello("james");
            c.Sum(1,2);
            int res = c.Cube(5);
            Console.WriteLine(res);
            c.Add(10);
            c.Add(10, 20);
            c.Add(10, 20, 30);
        }
    }
}