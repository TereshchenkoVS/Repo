// Напишите метод, который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
double[] cubeList(double N)
{
    double[] result = new double[Convert.ToInt32(N)];
    for (double i = 0; i < N; i++)
    {
        result[Convert.ToInt32(i)] = Math.Pow(i + 1, 3);
    }
    return result;
}

string arrayToStr(double[] array)
{
    return string.Join(", ", array);
}

System.Console.Write("Введите число: ");
string answer = arrayToStr(cubeList(Convert.ToDouble(Console.ReadLine())));

Console.WriteLine(answer);