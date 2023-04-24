//Arrays-To Store same datatype values in single variable
//Always index Starts with Zero.
//Syntax-Datatype[]  VarName = new Datatype [Array Size]
//Single Dimensional Array- Stores single list of various elements of similiar data type.
//Multiple Dimensional Array-Stores in tabular format of rows and columns as 2D or 3D.
//Jagged Array-Is an array of array.It stores multiple arrays of different length.


//SINGLE DIMENSIONAL ARRAY
//Decalaration
int[] arr = new int[5];
//Assigning
arr[0] = 10;
arr[1] = 20;
arr[2] = 30;
//Declaration without Size mentioned
int[] arr1 = {10, 20, 30};
//Another of Declaration without Size mentioned
int[] arr2 = new int[] {10, 20, 30};


//MULTI DIMENSIONAL ARRAY
//Declaration
int[,] num = new int[2, 3];
//Assigning
num[0,0]=10;
num[0,1]=20;

//Declaration without Size mentioned
int[,] num2 = new int[, ] { { 1, 2, 3 }, { 5,6,7} };

for(int i = 0; i < 2; i++)
{
    for(int j = 0; j < 3; j++)
    {
        Console.Write($"{num2[i ,j]}");
    }
    Console.WriteLine();
}




//Another of Declaration without Size mentioned
int[,] num1 = new int[,] { { 10, 20, 30 },{40,50, 60} };


//JAGGED ARRAY
int[][] jagArr = new int[3][];
jagArr[0] = new int[] {10,20,30};
jagArr[1] = new int[] {1,2};
jagArr[2]= new int[] {5,6,7,8};

for(int i = 0;i < 3;i++)
{
    for( int j = 0;j < jagArr[i].Length;j++)
    {
        Console.Write(jagArr[i][j] +"  ");
    }
    Console.WriteLine();
}



//Taking input from user
int[] a = new int[3];
for(int i=0;i<a.Length;i++)
{
    a[i]=Convert.ToInt16(Console.ReadLine());
}
for(int j=0;j<a.Length;j++)
{
    Console.WriteLine(a[j]);    
}

//Using ForEach Loop
foreach (int item in a)
{
    Console.WriteLine(item);
}


