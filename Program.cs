// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information


using System.Globalization;
using System.Xml.Linq;

//Задание 2
//Создаем масив из 3х элементов
int[] arr = new int[3];


//Запрашиваем ввод значений для элементов массива
try
{
    Console.WriteLine("Требуется выполнить последовательный ввод нескольких цифр");
    Console.WriteLine("Выполните ввод первой цифры");
    arr[0] = int.Parse(Console.ReadLine());
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: значение не задано или не является цифрой");
    Console.WriteLine(ex.StackTrace);
}
try
{
    Console.WriteLine("Выполните ввод второй цифры");
    arr[1] = int.Parse(Console.ReadLine());
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: значение не задано или не является цифрой");
    Console.WriteLine(ex.StackTrace);
}
try
{
    Console.WriteLine("Выполните ввод третьей цифры");
    arr[2] = int.Parse(Console.ReadLine());
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: значение не задано или не является цифрой");
    Console.WriteLine(ex.StackTrace);
}

//Выполняем расчет
if (arr.Length > 0)
{
    double arifm = (arr[0] + arr[1] + arr[2]) / 3;
    Console.WriteLine($"Среднее арифметическое значение: {arifm}");
}
