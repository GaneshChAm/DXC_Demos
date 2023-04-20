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

//Switch Case- Execution time is less.and directly jump to answer.
//Used mostly for menu drew situations.


int day = 3;
switch(day)
{
    case 1:
        {
            Console.WriteLine("Monday");
            break;
        }
    case 2:
        {
            Console.WriteLine("Tuesday");
            break;
        }
    case 3:
        {
            Console.WriteLine("Wenesday");
            break;
        }
    case 4:
        {
            Console.WriteLine("Tuesday");
            break;
        }
    case 5:
        {
            Console.WriteLine("Friday");
            break;
        }
    case 6:
        {
            Console.WriteLine("Saturday");
            break;
        }
    case 7:
        {
            Console.WriteLine("Sunday");
            break;
        }
        default:
        {
            Console.WriteLine("Invalid Input");
            break;
        }

}
//With Concantation
int a = 10, b = 15;
int c = a + b;
Console.WriteLine("The sum of "+ a +"and"+ b +"is"+ c);
//Without Concatation using '$'
int d = 10, e = 15;
Console.WriteLine($"The  sum {d} and {e} is {d + e}");