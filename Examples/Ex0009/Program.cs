// Показать четные числа от 1 до N

Console.WriteLine("Введите число ");
int value = Convert.ToInt32(Console.ReadLine());
int count = 2;

Console.WriteLine("Все четные числа до введенного числа: ");

while (count <= value)
{
    Console.WriteLine(count);
    count = count + 2;
}