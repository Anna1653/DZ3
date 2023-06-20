/*Задача 21
Напишите программу, которая принимает на вход координаты трех точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

string getPointName(int pointIndex){
        string pointName = "";
        switch (pointIndex)
        {
            case 0:
                pointName = "X";
                break;
            case 1:
                pointName = "Y";
                break;
            case 2:
                pointName = "Z";
                break;
        }
        return pointName;

}

int[] readCoordinates(int pointNum){
    int[] result = new int[3];

    for (int i = 0; i < result.Count(); i++)
    {
        string pointName = getPointName(i);
        Console.WriteLine($"Введите координаты {pointName}{pointNum}: ");
        result[i] = int.Parse(Console.ReadLine());
    }

    return result;
}

int[] coordinates1 = readCoordinates(1);
int[] coordinates2 = readCoordinates(2);

double result = Math.Sqrt(Math.Pow((coordinates2[0] - coordinates1[0]), 2) + 
    Math.Pow((coordinates2[1] - coordinates1[1]), 2) + 
    Math.Pow((coordinates2[2] - coordinates1[2]), 2));
Console.WriteLine($"Расстояние между точками равно: {result}");

/*
Console.WriteLine("Введите координаты X1: ");
int X1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты Y1: ");
int Y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты Z1: ");
int Z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты X2: ");
int X2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты Y2: ");
int Y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты Z2: ");
int Z2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2) + Math.Pow((Z2 - Z1), 2));
Console.WriteLine($"Расстояние между точками равно: {result}");
*/


