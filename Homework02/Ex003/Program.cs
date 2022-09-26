// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


System.Console.WriteLine("Введите день недели:");
int day = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(checkDay(day));

string weekend(int arg) //проверка на выходной
{
    if (arg == 6 || arg == 7)
    {
        string res = "Выходной!";
        return res;
    }
    else
    {
        string res = "Будний день!";
        return res;
    }
}

string checkDay(int value) //проверка на день недели
{
    if (value > 0 && value < 8)
    {
        string res = weekend(value);
        return res;
    }
    else
    {
        string res = "Число не является номером дня недели.";
        return res;
    }
}