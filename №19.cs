//Задача № 19

int num;
while (true)
{
    Console.WriteLine("Введите пятизначное число:");
    num = int.Parse(Console.ReadLine()!);
    if (num < 10000 || num > 99999)
    {
        Console.WriteLine("Некорректный ввод. Повторите попытку");
    }
    else
    {
        break;
    }
}

if (num > 10000 && num < 99999)
{
    if ((num / 10000 == (num % 10)) && ((num / 1000) % 10 == (num / 10) % 10))
    {
        Console.WriteLine(num + "- палиндромом!");
    }

    else
    {
        Console.WriteLine(num + "- не является палиндромом!");
    }

}

else
{
    Console.WriteLine("Число не пятизначное!!!");
}
