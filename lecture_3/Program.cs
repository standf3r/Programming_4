﻿// // Вид 1
// void Method1()
// {
//     Console.WriteLine("Автор...");
// }
// // Method1();

// // Вид 2

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// // Method2("Текст сообщения");

// // Вид 3

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// // int year = Method3();
// Console.WriteLine(year);

// Вид 4
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = string.Empty;
    
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
 
// }


// string Method4(int count, string text)
// {
//     string result = string.Empty;
//     for(int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
 
// }

// string res = Method4(10, "z");
// Console.WriteLine(res);

// for(int i = 2; i <= 10; i++)
// {
//     for(int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
// }

// Дан текст. В тексте нужно все пробелы заменить черточками.
// Маленькие буквы "к" заменить большими "К"
// А большие "С" заменить маленькими "с"

string text = "-Я думаю, - сказал князь, улыбаюсь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s ="qwerty"
//            012
// s [3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for(int i =0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|' );
Console.WriteLine(newText);