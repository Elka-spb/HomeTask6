// Площадь треугольника
Console.Clear();
void AriaTriangle(int x1, int y1, int x2, int y2, int x3, int y3)
{   double a = Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)), 2);
    double b = Math.Round(Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2)), 2);
    double c = Math.Round(Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2)), 2);

    double P = (a + b + c)/2;
    double S = Math.Sqrt(P*(P-a)*(P-b)*(P-c));
    Console.Write("Площадь треугольника равна: " + Math.Round(S, 2)); 
}

Console.WriteLine("Координаты первой точки: "); 
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координаты второй точки: "); 
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координаты третьей точки: "); 
int x3 = Convert.ToInt32(Console.ReadLine());
int y3 = Convert.ToInt32(Console.ReadLine());

AriaTriangle(x1, y1, x2, y2, x3, y3);