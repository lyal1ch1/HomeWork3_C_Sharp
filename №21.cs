
//Задача № 21
Console.WriteLine("Введите координату x1:");
double x1 = double.Parse (Console.ReadLine()!);

Console.WriteLine("Введите координату y1:");
double y1 = double.Parse (Console.ReadLine()!);

Console.WriteLine("Введите координату z1:");
double z1 = double.Parse (Console.ReadLine()!);

Console.WriteLine("Введите координату x2:");
double x2 = double.Parse (Console.ReadLine()!);


Console.WriteLine("Введите координату y2:");
double y2 = double.Parse (Console.ReadLine()!);


Console.WriteLine("Введите координату z2:");
double z2 = double.Parse (Console.ReadLine()!);

double distance = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2) );

Console.WriteLine($"Расстояние равно: {distance}" );
