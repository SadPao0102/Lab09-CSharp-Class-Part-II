StaticDemo.i = 123;
StaticDemo.f = 1234.56f;
StaticDemo.s = "Hello World!";
StaticDemo.PrintValues();

class StaticDemo
{
    public static int i; // แก้ไข "stattic" เป็น "static"
    public static float f; // แก้ไข "stattic" เป็น "static"
    public static string s; // แก้ไข "strang" เป็น "string"
    
    public static void PrintValues() // แก้ไข "stitac" เป็น "static"
    {
        System.Console.WriteLine($"Integer i : {i}, floating point f : {f}, string s : {s}"); // แก้ไข "Conxole" เป็น "Console" และ "Writeline" เป็น "WriteLine"
    }
}

