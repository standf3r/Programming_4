// Задача 30. Напишите программу которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

int [] Mass = new int [8];
Random NewMass = new Random();
for (int i=0; i<8; i++)
{
    Mass [i] = NewMass.Next (0,2);
    Console.Write($" {Mass[i]}");
}
