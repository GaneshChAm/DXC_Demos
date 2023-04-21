//Write a program to accept a 5 digit number and calculate the sum of all digits
Console.WriteLine("Enter the 5 Digit Number : ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0, rem;
while (n != 0)
{
    rem = n % 10;
    sum = sum + rem;
    n = n / 10;
}
Console.WriteLine($"The Sum of Digits is : {sum}");


//Write a program that prints out a table to show the temp in degree Celcius into degrees Fahrenheit.
//This table will contain 10 rows
Console.WriteLine("Sl.no\tTemp(C)\tTemp(F)");
for(int i=1,Celcius=0; i<=10;  i++,Celcius+=10)
{
    decimal Fahrenheit = (((Celcius * 9) / 5) + 32);
    Console.WriteLine($"{i}\t{Celcius}\t{Fahrenheit}");
}



//Write a program will accept the temperature in degrees Celcius from the user and display its into
//corresponding temperature in Fahrenheit.
//it should ask the user whether he wants to continue or not.The user can respond by typing ‘y’ or ‘n’.
String Choice;
do
{
    Console.WriteLine("Enter the Temperature in Degree Celcius: ");
    int temp=Convert.ToInt32(Console.ReadLine());
    decimal F = (((temp * 9) / 5) + 32);
    Console.WriteLine("Temperature(Celcius):"+ temp+"\t"+"Temperature(Fahrenheit):"+  F );
    Console.WriteLine("Do You wish to Continue (y/n)?");
    Choice = Console.ReadLine().ToLower();
} while (Choice == "y");
