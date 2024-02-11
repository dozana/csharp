/*
    String-ის გადაყვანა სხვა ტიპის მონაცემთა ტიპში
    მონაცემთა ტიპების ერთმანეთში გადაყვანა
*/

/*
string a = "5";
string b = "2";

int convertedA = Convert.ToInt32(a);
int convertedB = Convert.ToInt32(b);

Console.WriteLine("a + b = " + convertedA + convertedB);
Console.WriteLine(convertedA + convertedB);
*/


/*
string str;
int a, b;

Console.WriteLine("Enter First Number");
str = Console.ReadLine();
a = Convert.ToInt32(str);


Console.WriteLine("Enter Second Number");
str = Console.ReadLine();
b = Convert.ToInt32(str);

int result = a + b;

Console.WriteLine("Result = " + result);
*/



Console.WriteLine("Enter First Number");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Second Number");
int b = Convert.ToInt32(Console.ReadLine());

int result = a + b;

Console.WriteLine("Result = " + result);