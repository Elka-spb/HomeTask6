// task 43
Console.Clear();
void CrossPoint(double k1, double b1, double k2, double b2)
{   double x = (b2-b1)/(k1-k2);
    double y = (k1/(k1-k2))*(b2-b1)+b1;  
    if (k1 == k2) 
    Console.Write("Прямые не пересекаются, параллельны друг другу");
    else 
    Console.Write($"Координаты точки пересечения прямых: ({x}; {y})"); 
}

Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
CrossPoint(k1, b1, k2, b2);