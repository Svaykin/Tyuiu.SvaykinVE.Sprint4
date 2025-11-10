using Tyuiu.SvaykinVE.Sprint4.Task0.V20.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: Свайкин В. Е. | АСОиУб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы                                                *");
        Console.WriteLine("* Вариант #20                                                             *");
        Console.WriteLine("* Выполнил: Свайкин Владислав Евгеньевич | АСОиУб-25-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов, заполненный        *");
        Console.WriteLine("* статическими значениями в диапазоне от 0 до 9. Подсчитать произведение  *");
        Console.WriteLine("* четных элементов массива.                                               *");
        Console.WriteLine("* Массив: {4, 8, 7, 6, 5, 8, 2, 4, 3, 2}                                  *");
        Console.WriteLine("***************************************************************************");

        int[] array = { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };
        Console.WriteLine($"Произведение: {ds.GetMultEvenArrEl(array)}");
        Console.ReadKey();
    }
}