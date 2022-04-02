// Задача 25. Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
double b = Convert.ToInt32(Console.ReadLine());
double c = 1;
for (int i=0; i < b; i++)
{
    c=c*a;
}
 Console.WriteLine(c);
