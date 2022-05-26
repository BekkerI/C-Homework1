/*
21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите координаты X точки A: ");
int XpointA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y точки A: ");
int YpointA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Z точки A: ");
int ZpointA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты X точки B: ");
int XpointB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y точки B: ");
int YpointB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Z точки B: ");
int ZpointB = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt ((XpointB - XpointA) * (XpointB - XpointA) + (YpointB - YpointA) * (YpointB - YpointA) + (ZpointB - ZpointA)*(ZpointB - ZpointA));
 
Console.WriteLine("Растояние между точками -> " + Math.Round(result, 2));
