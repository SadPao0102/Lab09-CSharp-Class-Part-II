Circle.PrintCircleArea(100);

class Circle
{
    const double PI = 3.14159; // ค่าคงที่ PI ไม่สามารถเปลี่ยนแปลงได้
    public static void PrintCircleArea(double radius)
    {
        // ไม่สามารถเปลี่ยนแปลงค่า PI ได้ เนื่องจากเป็นค่าคงที่
        double precisePI = 3.14159265359; // ใช้ตัวแปรใหม่สำหรับค่า PI ที่แม่นยำกว่า
        System.Console.WriteLine($"Radius = {radius}, Area = {precisePI * radius * radius}"); // แก้ไขตัวแปรที่ใช้ให้ถูกต้อง
    }
}

