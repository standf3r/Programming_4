// Задача 27. Напишите программу, коротая принимает на вход число и выдает сумму цифр в числе.

Console.Write("Введите число :");
string a = Convert.ToString(Console.ReadLine());
            int summ = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (char.IsNumber(a[i]))
                {
 
                    summ += Convert.ToInt32(a[i].ToString());
                }
            }
Console.WriteLine($"Сумма числе равнa: {summ}");


 

