double r = 100.0; // แก้ไข "douple" เป็น "double"
Circle.PrintCircleArea(r);
Circle.PrintCircleCircumference(r);

class Circle // แก้ไข "Class" เป็น "class"
{
    const double PI = 3.14159; // แก้ไข "doublE" เป็น "double"
    const double PI2 = PI * 2.0; // แก้ไข "douBle" เป็น "double"
    
    public static void PrintCircleArea(double radius)
    {
        System.Console.WriteLine($"Radius = {radius}, Area = {PI * radius * radius}"); // แก้ไข "console.write line" เป็น "Console.WriteLine"
    }
    
    public static void PrintCircleCircumference(double radius)
    {
        System.Console.WriteLine($"Radius = {radius}, Circumference = {PI2 * radius}"); // แก้ไข "console.writeli ne" เป็น "Console.WriteLine"
    }
}

