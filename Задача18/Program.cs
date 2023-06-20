/*Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).*/

Console.WriteLine("Введите номер четвети от 1 до 4: ");
int a = int.Parse(Console.ReadLine());

switch (a)
{
    case 1: 
    Console.WriteLine("Диапазон x > 0, y > 0");
    break;

    case 2: 
    Console.WriteLine("Диапазон x > 0, y < 0");
    break;

    case 3: 
    Console.WriteLine("Диапазон x < 0, y < 0");
    break;

    case 4: 
    Console.WriteLine("Диапазон x < 0, y > 0");
    break;

    default: Console.WriteLine("Вы ввели не верное значение");
    break;
}