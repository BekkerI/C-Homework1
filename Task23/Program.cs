/*
23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9. 
5 -> 1, 8, 27, 64, 125
3 -> 1, 8, 27 
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i  <= number)
{
    Console.Write (i*i*i + ", ");
    i++;
}
