//To accept 3 numbers from user and display largest among them
using System;
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



//Write a program to accept student details like(StudentID,StudentName,StudentAge,Marks1,Marks2,Marks3).
//Calculate Total Score,Average,Grade and Result.
//If Student Scores Average greater than 50 is Pass orelse Fail.
//The Grade Criteria is As Follows:90-100 as A,80-89 as B,60-79 as C,50-59 as D,<50 as E.

String Studentname, StudentID;
int StudentAge, Marks1, Marks2, Marks3, TotalMarks;
decimal Average;
Console.WriteLine("Enter the StudentID");
StudentID=Convert.ToString(Console.ReadLine());
Console.WriteLine("Enter the StudentName");
Studentname = Console.ReadLine();
Console.WriteLine("Enter the StudentAge");
StudentAge = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter the Marks1");
Marks1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter the Marks2");
Marks2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter the Marks3");
Marks3 = Convert.ToInt16(Console.ReadLine());
//Total Marks
TotalMarks=(Marks1 + Marks2 + Marks3);
Console.WriteLine("Your Score is " + TotalMarks);
//Total Average
Average = (TotalMarks/3);
Console.WriteLine("Your Average is " + Average);
//Grade
if (Average >= 90)
{
   Console.WriteLine("Your Grade is A");
}
else if (Average >= 80)
{
    Console.WriteLine("Your Grade is B");
}
else if (Average >= 60)
{
    Console.WriteLine("Your Grade is C");
}
else if (Average >50)
{
    Console.WriteLine("Your Grade is D");
}
else 
{
    Console.WriteLine("Your Grade is E");
}
//Result
if (Average >50 )
{
    Console.WriteLine("Your Result For the Exam is Pass");
}
else
{
    Console.WriteLine("Your Result For the Exam is Fail");
}




