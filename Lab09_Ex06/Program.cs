Circle.PrintCircleArea(100);

class Circle
{
    const double PI = 3.14159; // คงที่สำหรับค่า PI

    public static void PrintCircleArea(double radius) // แก้ไข "statix" เป็น "static"
    {
        System.Console.WriteLine($"Radius = {radius}, Area = {PI * radius * radius}"); // แก้ไข "Conxole" เป็น "Console" และ "Wroteline" เป็น "WriteLine"
    }
}
