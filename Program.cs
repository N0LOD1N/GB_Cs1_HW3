// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Задача 19------------------------------");

int Zeros(int num)
{
    int length = 0;
    while (num >= 10)
    {
        num /= 10;
        length += 1;
    }
    return Convert.ToInt32(Math.Pow(10, length));
}

int RemoveFirst(int num)
{
    int front = num - Zeros(num) * (num / Zeros(num));
    return front;
}

void Pali()
{
    Console.Write("Введите пятизначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int count = Zeros(num);
    if (num >= 10000 && num <= 99999)
    {
        bool status = true;
        while (status == true && count >= 100)
        {
            int first = num / Zeros(num);
            int last = num % 10;
            if (first != last) status = false;

            num = RemoveFirst(num) / 10;
            count /= 100;
        }
        if (status == true)
        Console.WriteLine("Число, которое вы ввели - палиндром!");
        else
        Console.WriteLine("Число, которое вы ввели - не палиндром.");
    }
    else
    {
        Console.WriteLine("Число, которое вы ввели, не является пятизначным.Повторите попытку");
        Pali();
    }
}

Pali();


// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. 

Console.WriteLine("\nЗадача 21------------------------------");

double DistAB3D(int xA, int xB, int yA, int yB, int zA, int zB)
{
    double longLine = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));
    longLine = Math.Round(longLine, 2);
    return longLine;
}

Console.Write("Введите X координату точки А: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y координату точки А: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z координату точки А: ");
int zA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите X координату точки Б: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y координату точки Б: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z координату точки Б: ");
int zB = Convert.ToInt32(Console.ReadLine());

double dist = DistAB3D(xA,xB, yA, yB, zA, zB);
Console.WriteLine($"Расстояние между точкой А ({xA}, {yA}, {zA}) и точкой Б ({xB}, {yB}, {zB}):  {dist}");

// Задача 23: Напишите программу, которая принимает на вход число N и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("\nЗадача 23------------------------------");

void Cube1ToN(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.Write(i*i*i);
        if (i < num) Console.Write(", ");
        else if (i == num) Console.Write(".");
        if (i % 5 == 0) Console.WriteLine();
        
    }
    Console.WriteLine();
}

Console.Write("Введите число: ");
int userNum = Convert.ToInt32(Console.ReadLine());
Cube1ToN(userNum);
