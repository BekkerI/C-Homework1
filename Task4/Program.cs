/*
Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
2,3,7 -> 7
44,5,78 -> 78
22,3,9 -> 22
*/

Console.WriteLine("Введите числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
//int MAX = Math.Max(Math.Max(a, b), c); // Буду честен, эту функцию подсмотрел в интернете))
//Console.WriteLine("Max = " + MAX);


if (a > b & a > c)
{
    Console.WriteLine("Max = " + a);
}
if (b > a & b > c)
{
    Console.WriteLine("Max = " + b); 
}
if (c > a & c > b)
{
    Console.WriteLine("Max = " + c);
}
// Эту написал сам))