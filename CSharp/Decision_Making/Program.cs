// Decision making constructs in c#
//If... Else
//Switch...Case
//Arithmetic operators- +,-,*,/,%
//Comparision operators- ==,<,>,<=,>=,!=

int num;
Console.WriteLine("Enter a number");
num=Convert.ToInt16(Console.ReadLine());
if(num%2 ==0)
{
    Console.WriteLine("Number is Even");
}
else
{
    Console.WriteLine("Number is Odd");
}


int num1,num2;
Console.WriteLine("Enter First number");
num1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter Second number");
num2 = Convert.ToInt16(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("First number is greater");
}
else if (num2 > num1)
{
    Console.WriteLine("Second number is greater");
}
else
{
    Console.WriteLine("Both are equal");
}


//Logical operators- &&,||,!
//Age>=18 and Qualification>=10
Console.WriteLine("Enter Your Age");
int age = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter Your Qualification");
int qual = Convert.ToInt16(Console.ReadLine());
if (age>=18 && qual>=12)
{
    Console.WriteLine("Eligible");
}
else
{
    Console.WriteLine("Not Eligible");
}

//Nested if condition
Console.WriteLine("Enter Your Age");
int Age = Convert.ToInt16(Console.ReadLine());
if(Age>=18)
{
    Console.WriteLine("Enter Your Qualification");
    int Qual = Convert.ToInt16(Console.ReadLine());
    if (Qual>=12)
    {
        Console.WriteLine("Eligible");
    }
    else 
    {
        Console.WriteLine("Not Eligible");
    }
}
else
{
    Console.WriteLine("Not Eligible");
}