// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Введите число ");
int value = Convert.ToInt32(Console.ReadLine());
int count = 2;

Console.WriteLine("Все четные числа до введенного числа: ");

while (count <= value)
{
    Console.WriteLine(count);
    count = count + 2;
}

