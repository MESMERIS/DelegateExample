using System;
public delegate void HelloFunctionDelegate(string Message);
class program
{
    public static void Main()
    {
        HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
        Hello("Hello From Delegate");
    }
    public static void Hello(string strMessage)
    {
        Console.WriteLine(strMessage);
        Console.ReadLine();
    }
}