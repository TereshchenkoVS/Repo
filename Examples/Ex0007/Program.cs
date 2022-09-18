// Выяснить является ли число чётным

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