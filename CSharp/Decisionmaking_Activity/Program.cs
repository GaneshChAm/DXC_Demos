//To accept 3 numbers from user and display largest among them
using System.Reflection.Metadata;

int num1, num2, num3;
Console.WriteLine("Enter First Number");
num1=Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter Second Number");
num2 =Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter Third Number");
num3 =Convert.ToInt16(Console.ReadLine());
if (num1 >num2)
{
    if (num1 > num3)
    {
        Console.WriteLine("First Number is Largest");
    }
    else
    {
        Console.WriteLine("Third Number is largest");
    }
}
else if (num2 > num3)
{
    Console.WriteLine("Second Number is Largest");
}
else
{
   Console.WriteLine("Third Number is Largest");
}


// To accept a Alphabet check Wheather it is Vowel or Constant
char A;
Console.WriteLine("Enter the Alphabet");
A=Convert.ToChar(Console.ReadLine());

if(A=='a' || A=='e' || A=='i' || A=='o' || A=='u')
{
    Console.WriteLine("Given Alphabet is Vowel="+ A);
}
else
{
    Console.WriteLine("Given Alphabet is Constant="+ A);
}






