
//Задача № 23

 Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);

if (num < 0)
{
    num = -num;
}

for (int i =1; i < num; i++)
{
    Console.Write(Math.Pow(i, 3) + ", ");
}

Console.Write(Math.Pow(num, 3) + ".");