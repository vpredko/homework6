Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
if (k1 == k2)
    if (b1 == b2)
        Console.WriteLine("Точек пересечения бесконечно много");
    else
        Console.WriteLine("Точек пересечения нет, прямые параллельны");
else
    Console.WriteLine("Координаты точек пересечения: ");
    double x = (b1-b2)/(k2-k1);
    double y = k1 * x + b1;
    Console.WriteLine(x + " , " + y);
    
        
    