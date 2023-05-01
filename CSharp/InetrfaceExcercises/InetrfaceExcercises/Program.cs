//Excercise-1:
//Create a C# program that implements an IVehiculo interface with two methods, one for Drive of type void and another for Refuel of type bool that has a parameter of type integer with the amount of gasoline to refuel.
//Then create a Car class with a builder that receives a parameter with the car's starting gasoline amount and implements the Drive and Refuel methods of the car.
//The Drive method will print on the screen that the car is Driving, if the gasoline is greater than 0. The Refuel method will increase the gasoline of the car and return true.
//To carry out the tests, create an object of type Car with 0 of gasoline in the Main of the program and ask the user for an amount of gasoline to refuel, finally execute the Drive method of the car
//namespace InetrfaceExcercises
//{
//    internal class Program
//    {
//        interface IVehiculo
//        {
//            void Drive();
//            bool Refuel(int Amount);
//        }
//        class Car : IVehiculo
//        {
//            public int Gasoline;
//            public Car(int StartGasoline)
//            {
//                Gasoline = StartGasoline;
//            }

//            public void Drive()
//            {
//                if(Gasoline > 0)
//                {
//                    Console.WriteLine("The car is driving.");
//                }
//            }
//            public bool Refuel(int Amount)
//            {
//                Gasoline += Amount;
//                return false;
//            }
//        }
//        static void Main(string[] args)
//        {
//            Car car = new Car(0);
//            Console.Write("Enter the amount of gasoline to refuel: ");
//            int amount = int.Parse(Console.ReadLine());
//            car.Refuel(amount);
//            car.Drive();

//        }
//    }
//}


//Excercise-2:
//Create a Custom Generic C# class named MyStack. This class should contain Push, Pop methods and Count property. Push Method should Take only class object as argument and should create an in memory stack representation of given object type (Use Arrays). Pop method should remove and return the object in top of the stack. Count property should hold number of object in the Stack.
 class MyStack<T>
{
    public T[] array;
    public int count;
    public MyStack()
    {
        array = new T[5];
        count = 0;
    }
    public void Push(T Obj)
    {
        array[count] = Obj;
        count++;
    }
    public T Pop()
    {
        T item = array[count-1];
        count--;
        return item;
        
    }
}
internal class Program
{
    static void Main(String[] args)
    {
        int j = 0;
        int z = 0;

        //Data type as int
        MyStack<int> mystack = new MyStack<int>();
        mystack.Push(1);
        mystack.Push(2);
        mystack.Push(3);

        foreach (int i in mystack.array)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine($"Number of Objects in the stack = {mystack.count}");    
        Console.WriteLine($"Poped item-{++j} is:{mystack.Pop()}");
        Console.WriteLine($"Poped itam-{++j} is:{mystack.Pop()}");
        Console.WriteLine();

        // Data type as string
        MyStack<string> mystack1 = new MyStack<string>();
        mystack1.Push("one");
        mystack1.Push("two");
        mystack1.Push("three");
        mystack1.Push("four");

        foreach (string i in mystack1.array)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine($"Number of Objects in the stack = {mystack1.count}");
        Console.WriteLine($"Poped item-{++j} is:{mystack1.Pop()}");
        Console.WriteLine($"Poped itam-{++j} is:{mystack1.Pop()}");


    }
}