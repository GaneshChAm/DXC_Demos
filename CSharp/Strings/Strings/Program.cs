using System.Text;
//string str = "Hello";       //here string is datatype-both works same
//String  str1= "Welcome";    //here string is class- both works same

//string path = "c:\\Folder1\\File1.txt";
//string path1 = @"c:\folder1\File1.txt:";

////Strings are immutable.Once declared cannot be changed
//string st = "Welcome to CSharp";
//string res = str.Remove(0,3);          //Deletion
//Console.WriteLine(res);
//string st2 = st.Insert(11, "Microsoft ");//Insertion
//Console.WriteLine(st2); 
//Console.WriteLine(st.Substring(8,2));   //Substring
////Null values
//string s = String.Empty;
//string s1 = " ";
//string s3 = null;
////Format Strings

////Strings and indexes
//string name = "john";
//Console.WriteLine(name.IndexOf('o'));

//string message = "Welcome to my first program";
//Console.WriteLine(message.IndexOf('o'));
//Console.WriteLine(message.LastIndexOf('o'));
////String Operations
////String Comparision
//string str3 = "Hello";
//string str2 = "Hello";
//string str4 = "hello"; 
//Console.WriteLine(str3 == str2);
//Console.WriteLine(str3 == str4);

//Console.WriteLine(str3.CompareTo(str2));
//Console.WriteLine(str3.CompareTo(str4));
//Console.WriteLine(str4.CompareTo(str3));

//Console.WriteLine(String.Compare(str3, str2));
////String Equality
//Console.WriteLine(str3.Equals(str2));
//Console.WriteLine(str3.Equals(str2,StringComparison.OrdinalIgnoreCase));

////String Search
//string msg = "Hello and Welcome to String Concept";
//Console.WriteLine(msg.StartsWith('H'));
//Console.WriteLine(msg.EndsWith('p'));
////String Split
//string[] result = msg.Split(" ");
//foreach (var item in result)
//{
//    Console.WriteLine(item);    
//}
//.NET StringBuilder - represents a mutable string of characters.This class cannot be inherited.
//Used for operations that perform string manipuklation and modifing repeatedly.
//Better to use this class,which is mutable string
//16 charcters is default capacity.32 bit is max value

StringBuilder sb = new StringBuilder("Welcome to  StringBuilder");
sb.Append("!");
sb.Insert(11, "new");
Console.WriteLine(sb);   
//Console.WriteLine(sb.Capacity);
//Console.WriteLine(sb.Length);
