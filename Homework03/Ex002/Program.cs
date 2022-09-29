//Напишите метод, который принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
double[] strToArr(string input)
{
    input = input.Replace(" ", "");
    string[] array1 = input.Split(",");
    double[] array2 = new double[array1.Length];
    for (int i = 0; i < array1.Length; i++)
    {
        array2[i] = Convert.ToDouble(array1[i]);
    }
    return array2;
}

double findDist(double[] x, double[] y)
{
    double sum = 0;
    for (int i = 0; i < x.Length; i++)
    {
        sum += Math.Pow(x[i] - y[i], 2);
    }
    sum = Math.Sqrt(sum);
    return sum;
}

System.Console.WriteLine("Введите координаты первой точки через запятую: ");
double[] A = strToArr(Console.ReadLine());
System.Console.WriteLine("Введите координаты второй точки через запятую: ");
double[] B = strToArr(Console.ReadLine());

Console.WriteLine(findDist(A, B));