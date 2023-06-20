/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введите пятизначное число: ");
string numStr = Console.ReadLine();
try
{
    int num = int.Parse(numStr);
	if (num < 10000 || num >= 99999)
	{
		Console.WriteLine("Введено не пятизначное число");
		return;
	}
}
catch (Exception ignore)
{
    Console.WriteLine("Введено не число");
    return;
}
int j = numStr.Count() - 1;
bool result = true;
for(int i = 0; i < j; i++)
	{
		if(numStr[i] != numStr[j]) 
		{
			result = false;
			break;
		}
		j--;
	}
if (result) 
{
	Console.WriteLine("Число палиндром");
} 
else 
{
	Console.WriteLine("Число не палиндром");
}