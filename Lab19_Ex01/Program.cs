// 2. add target method to delegate
MyDelegate myDel1 = new MyDelegate(MyMethod);
MyDelegate myDel2 = MyMethod;

// 3. Invoke delegate
myDel1("Hello World");
myDel1.Invoke("Hello Mars");
myDel2("Hello Saturn");

static  void  MyMethod(string message)
{
    System.Console.WriteLine(message);
}

// 1. declare delegate
public delegate void MyDelegate(string message);