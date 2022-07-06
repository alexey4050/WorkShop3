// Задача 21. Напишите программу, которая принимает на ввод координаты двух точек и находит расстояние между ними а 3D пространстве.
// А(3, 6, 8); B(2, 1, -7)-. 15.84
// A(7, -5, 0); B(1, -1, 9)-> 11.53

Console.WriteLine("Задача 21. ");
int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("x", "B");
int z2 = Coordinate("x", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату{coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}
double Disision(double x1, double x2,
                 double y1, double y2,
                 double z1, double z2){
return Math.Sqrt(Math.Pow((x2-x1), 2) +
                 Math.Pow((y2-y1), 2) +
                 Math.Pow((z2-z1), 2));
}
double segmentLength = Math.Round (Disision(x1, x2, y1, y2, z1, z2), 2);

Console.WriteLine($"Длина отрезка {segmentLength}");