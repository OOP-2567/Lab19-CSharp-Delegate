// Action
Action a = Print;
a();

Action<int, int, int> s = PrintSum;
s(4, 5, 6);

Action<int, int> sum = (a, b) =>
{
    var x = a + b;
    System.Console.WriteLine("result = " + x);
};
sum(8, 2);


static void Print()
{
    System.Console.WriteLine("Hello World");
}
static void PrintSum(int a, int b, int c)
{
    System.Console.WriteLine($"sum = {a + b + c}");
}