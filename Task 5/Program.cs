﻿Console.Clear();

Console.Write(" Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());

if (a * a == b || b * b == a )
    Console.WriteLine( "Yes!");
else 
    Console.WriteLine(" No");