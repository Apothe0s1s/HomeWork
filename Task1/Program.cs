// Задача 2. Напишите программу, которая на входе принимает 2 числа и выдает, какое число больше, а какое меньше.
Console.WriteLine("Введите число A");
Console.WriteLine("Введите число B");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
if(A>B)
{
    Console.WriteLine("Число A больше числа B ");
}
else
{
    Console.WriteLine("Число B больше числа A ");
}