﻿/*
Написать программу, которая из имеющегося массива строк формирует 
массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать 
на старте выполнения алгоритма. 
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

Console.WriteLine ("Введите некоторые строки разной длины через пробел \n");
string text = Console.ReadLine ();
string [] array = text.Split(' ');
for (int i = 0; i < array.Length; i++)
    {   
        if (array[i].Length <=3) Console.WriteLine(array[i]);
    }