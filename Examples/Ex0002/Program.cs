// По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("Введите первое число: ");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int value2 = Convert.ToInt32(Console.ReadLine());

if (value1 == value2 * value2)
{
    Console.WriteLine($"{value1} является квадратом {value2}");
}
else
{
    Console.WriteLine($"{value1} не является квадратом {value2}");
}
