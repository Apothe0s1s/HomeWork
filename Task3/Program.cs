// Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.
Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());

if(A%2 == 0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число не чётное");
}