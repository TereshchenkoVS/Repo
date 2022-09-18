// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число ");
int value = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Четное ли число?");


if (value % 2 == 0)
{
    Console.WriteLine($"{value} = Четное");
}
else
{
    Console.WriteLine($"{value} = Нечетное");
}