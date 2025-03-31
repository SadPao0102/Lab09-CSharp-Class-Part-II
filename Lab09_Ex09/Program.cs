Circle.PrintCircleArea(100);

class Circle
{
    static readonly double PI = 3.14159265359; // ใช้ static readonly แทน const เพื่อให้เปลี่ยนค่าได้ตอน runtime

    public static void PrintCircleArea(double radius)
    {
        System.Console.WriteLine($"Radius = {radius}, Area = {PI * radius * radius}");
    }
}

