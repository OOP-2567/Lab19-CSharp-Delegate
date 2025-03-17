
var im = new InstanceMethod();
MyDelegate imdel = im.MethodA;
MyDelegate smdel = StaticMethod.MethodB;
MyDelegate amdel = (string message) => System.Console.WriteLine($"You are calling anonymous method with message {message}");

MyDelegate del = imdel ?? smdel; 
System.Console.WriteLine("------------------");
System.Console.WriteLine("imdel + smdel");

del = imdel + smdel;  
del?.Invoke("Hello world");  

System.Console.WriteLine("------------------");
System.Console.WriteLine("imdel + smdel + amdel");
del += amdel;  
del?.Invoke("Hello world");  
System.Console.WriteLine("------------------");
System.Console.WriteLine("del -= imdel");
del -= imdel;  
del?.Invoke("Hello world");  

class InstanceMethod
{
    public void MethodA(string message)
    {
        System.Console.WriteLine($"You are calling instance MethodA() with message {message}");
    }
}

static class StaticMethod
{
    public static void MethodB(string message)
    {
        System.Console.WriteLine($"You are calling static MethodB() with message {message}");
    }
}

public delegate void MyDelegate(string message);