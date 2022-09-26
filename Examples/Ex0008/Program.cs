// Показать числа от -N до N

Console.WriteLine("Введите отрицательное число ");
int value1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите положительное число ");
int value2 = Convert.ToInt32(Console.ReadLine());

int count = value1;

Console.WriteLine($"Все четные числа от {value1} до {value2} ");

while (count <= value2)
{
    Console.WriteLine(count);
    count++;
}