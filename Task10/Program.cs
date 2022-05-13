/*
10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8 
918 -> 1
*/

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int mult = (number / 10) % 10; 

if  (number < 100)
{
    Console.WriteLine("Неверное число");
}
else if (number > 999)
{
    Console.WriteLine("Неверное число");
}
else 
{
    Console.WriteLine(mult);
}
