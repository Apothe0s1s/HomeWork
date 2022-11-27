// Задача 4. Напишите программу, которая на входе принимает 3 числа и выдает и выдает максимальное из этих чисел.
Console.WriteLine("Введите число A");
Console.WriteLine("Введите число B");
Console.WriteLine("Введите число C");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int C = Convert.ToInt32(Console.ReadLine());

int max = A;

if(A > max) max = A;
if(B > max) max = B;
if(C > max) max = C;

Console.WriteLine(max);