//Ex-1:Write a program to display the largest number in given array {7,4,5,6,8,2,3,1}.
int[] arr1 = { 7, 4, 5, 6, 8, 2, 3, 1 };
int n = arr1[0];
for (int i = 1; i < arr1.Length; i++)
{
    if (arr1[i] > n)
    {
        n = arr1[i];
    }
}
Console.WriteLine("The largest number in the given array is: " + n);
//Using Predefined Functions
Console.WriteLine("The largest number in the given array is: " + arr1.Max());


//Ex-2:Write a program to display the element that occurs most frequentyly in given array {7,7,7,7,8,8,8,5,5,5,5,6,6,6,6}.
int[] arr2 = { 7, 7, 7, 7, 8, 8, 8, 5, 5, 5, 5, 6, 6, 6, 6 };
int maxCount = 0;
for (int i = 0; i < arr2.Length; i++)
{
    int count = 1;
    for (int j = i + 1; j < arr2.Length; j++)
    {
        if (arr2[i] == arr2[j])
        {
            count++;
        }
    }
    if (count > maxCount)
    {
        maxCount = count;
    }
}
Console.Write("The element that occurs most frequentyly in given array is ");
for (int i = 0; i < arr2.Length; i++)
{
    int count = 1;
    for (int j = i + 1; j < arr2.Length; j++)
    {
        if (arr2[i] == arr2[j])
        {
            count++;
        }
    }
    if (count == maxCount && Array.IndexOf(arr2, arr2[i]) == i)
    {
        Console.Write(arr2[i] + " ");
    }
}
Console.WriteLine();


//Ex-3:Write a program to count the Duplicate values in an array of Size 10.
int[] arr3 = new int[10];
int count3 = 0;
Console.WriteLine("Enter the 10 values: ");
for (int i=0; i < arr3.Length; i++) 
{
    arr3[i] = Convert.ToInt32(Console.ReadLine());
}    
for (int i = 0; i < arr3.Length; i++)
{
    for (int j = i + 1; j < arr3.Length; j++)
    {
        if (arr3[i] == arr3[j])
        {
            count3++;
            break;
        }
    }
}
Console.WriteLine("The number of duplicate values in the array is: " + count3);


//Ex-4:Write a program to calculate the average of the elements in given array of size 10.All values must be accepted from user.
int[] arr4 = new int[10];
int sum1 = 0;
Console.WriteLine("Enter 10 integers:");
for (int i = 0; i < arr4.Length; i++)
{
    arr4[i] = Convert.ToInt32(Console.ReadLine());
    sum1 += arr4[i];
}
decimal avg = (decimal)sum1 / arr4.Length;
Console.WriteLine("The average of the elements in the array is: " + avg);
//Using Predefined Functions
decimal sum = arr4.Sum();
int count4 = arr4.Count();
decimal Avg1 = sum / count4;
Console.WriteLine("The average of the elements in the array is: " + Avg1);