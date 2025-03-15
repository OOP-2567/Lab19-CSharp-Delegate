// Lambda expression
Square getSquare = x=> x*x ; // 2. define lambda expression

int num = 9;
int sqr = getSquare(num);
System.Console.WriteLine($"Square value of {num} is {sqr}");

delegate int Square(int num);  // 1. declare delegate