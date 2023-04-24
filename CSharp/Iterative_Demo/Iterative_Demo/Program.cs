// Types of Loops-For,While,Do..While,For Each

//For Loop
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

//While Loop
int j = 1;
while(j <= 10)
{
    Console.WriteLine(j);
    j++;
}

//Do While-Execute atleast once;Used for menu drew program;Check Condition at End
int k = 1;
do
{
    Console.WriteLine(k);
    k++;
}while(k >= 10);

//Nested Loops-Loop within another Loop
for (int i = 1;i <= 10;i++ )
{
    for( j= 1; j <= 10;j++ )
    {
        Console.Write(j);
    }
    Console.WriteLine();
}









