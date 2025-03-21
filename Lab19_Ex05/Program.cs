// generic delegate

Add<int> sum = NumericSum;
int a = 30, b = 50;
System.Console.WriteLine($"Numeric sum of {a} and {b} is {sum(a, b)}");

Add<string> con = StringConcat;
string h = "hello", w = "World";
System.Console.WriteLine($"String concatenate of '{h}' and '{w}' is \"{con(h, w)}\"");


static int NumericSum(int val1, int val2)
{
    return val1 + val2;
}

static string StringConcat(string str1, string str2)
{
    return str1 + " " + str2;
}

public delegate T Add<T>(T param1, T param2); // generic delegate