namespace ExceptionHandling
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c = 0;
            
            try
            {
                Console.WriteLine("Enter First Number");
                a = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                b = Convert.ToInt16(Console.ReadLine());
                if(a < b)
                {
                    throw new IncorrectValueException("Value of First number cannot be less than the Second number");
                }               
                c = a / b;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("You cannot divide any number with Zero");
            }  
            catch(FormatException)
            {
                Console.WriteLine("Only numbers are allowed");
            }
            catch(IncorrectValueException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Something Wrong");
            }
            finally
            {
                Console.WriteLine($"The Result is: {c}");
                Console.WriteLine("The Program Ends.");
            }
            
        }
    }
}