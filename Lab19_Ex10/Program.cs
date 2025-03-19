// Func
Func<int, int, int> add = Add;
int a = 5, b= 9;
int c = add(a,b);
System.Console.WriteLine($"Add({a}, {b}) return {c}");

Func <string, string> convertToUpper = s => s.ToUpper();
string before = "all Lowercase characters";
System.Console.WriteLine($"Before = \"{before}\", after = \"{convertToUpper(before)}\"");

static int Add(int a, int b)
{
    return a + b;
}