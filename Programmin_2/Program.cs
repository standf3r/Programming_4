// Напишите цикл, который принимает на вход два числа (А и В) и возводит число В в натуральную степень А.

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
double b = Convert.ToInt32(Console.ReadLine());
// double c = Math.Pow(b,a);
double c = 1;
for (int i=0; i < a; i++)
{
    c=c*b;
}
 Console.WriteLine(c);

// Решил с помошью команды которая возводит число в натуральную степень Math.Pow
