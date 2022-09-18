// Найти максимальное из трех чисел

Console.WriteLine("Введите числа (a),(b),(c)");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = a;



if (b > max) max = b;
if (c > max) max = c;



Console.Write("max = ");
Console.WriteLine(max);