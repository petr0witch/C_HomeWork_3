// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// 2234322
/*
void Palind(int number)
{  
    if (number < 100000 && number > 9999)
    {
        int start = number / 1000;
        int end = number % 100;
        if (end - start == 9) Console.Write("Number is Palindrom"); 
        else Console.Write("Just number"); 
    }
    else Console.Write("Your number is not correct");
}

Console.Write("Enter your number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

Palind(userNumber);
*/


// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double Func(double xPos1, double yPos1, double zPos1, double xPos2, double yPos2, double zPos2)
{
    double result = Math.Sqrt(Math.Pow(xPos2 - xPos1, 2) + Math.Pow(yPos2 - yPos1, 2) + Math.Pow(zPos2 - zPos1, 2));
    return Math.Round(result, 2);
}

Console.Write("x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Func(x1, y1, z1, x2, y2, z2));
*/

// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
/*
void Cub(int number)
{
    int i = 1;
    while (i <= number)
    {
        Console.WriteLine(Math.Pow(i, 3));
        i++;
    }
}

 Console.Write("Enter your N: ");
int n = Convert.ToInt32(Console.ReadLine());

Cub(n);
*/