namespace GenericsDemo
{
    class Demo<T>
    {
        T num;
        public void SetValue(T x)
        {
            num = x; 
        }
        public T GetValue()
        {
            return num;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo<int>obj = new Demo<int>();
            obj.SetValue(1);
            Console.WriteLine(obj.GetValue());
            Demo<string> obj1 = new Demo<string>();
            obj1.SetValue("Hello");
            Console.WriteLine(obj1.GetValue());

        }
    }
}