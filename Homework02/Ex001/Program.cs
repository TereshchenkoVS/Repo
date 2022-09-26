// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите техзначное число");
int value = Convert.ToInt32(Console.ReadLine());


if (value > 99 && value < 1000)
{
    int num = (value % 100) / 10;
    Console.WriteLine($"Вторая цифра в числе {value} = {num} ");
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число!");
}