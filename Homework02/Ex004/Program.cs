// Напишите программу, которая принимает на вход семь чисел, и находит их среднее арифметическое

System.Console.WriteLine(" Введите 7 чисел:");
Console.WriteLine("Число a = ");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число b = ");
double b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число c = ");
double c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число d = ");
double d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число e = ");
double e = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число f = ");
double f = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число g = ");
double g = Convert.ToInt32(Console.ReadLine());

double rezult = (a + b + c + d + e + f + g) / 2;

Console.WriteLine(rezult);