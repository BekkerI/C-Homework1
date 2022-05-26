/*
19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10000 || number > 99999)
{
    Console.WriteLine($"{number} -> не пятизначное число!!!");
}
else if ((number/10000 == number % 10) && ((number / 1000)%10 == (number % 100) / 10))
{
    Console.WriteLine($"{number} -> да, это полиндром");
}
else
{
    Console.WriteLine($"{number} -> нет, это не полиндром");
}
