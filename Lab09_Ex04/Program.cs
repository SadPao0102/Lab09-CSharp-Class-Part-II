using System;

class Program
{
    static void Main(string[] args)
    {
        var a1 = new AAA();
        var a2 = new AAA();
        a1.b1 = 10;
        AAA.b2 = 20; // ใช้ชื่อคลาสเข้าถึง static member
        a2.b1 = 30;
        AAA.b2 = 40; // ใช้ชื่อคลาสเข้าถึง static member

        Console.WriteLine($"a1.b1 = {a1.b1}");
        Console.WriteLine($"AAA.b2 = {AAA.b2}");
        Console.WriteLine($"a2.b1 = {a2.b1}");
        Console.WriteLine($"a2.b2 = {AAA.b2}"); // เข้าถึง static member ผ่านชื่อคลาส
    }
}

class AAA 
{
    public int b1;
    public static int b2; // ประกาศ b2 เป็น static
}

