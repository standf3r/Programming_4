// Задача 28. Принимает на вход число N, а выдает произведение чисел от 1 до N

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int factorial = 1;   // значение факториала

for (int i = 1; i <= a; i++) 
{
     factorial = factorial * i;
}
Console.Write(factorial);