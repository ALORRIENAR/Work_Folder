﻿/*
Console.Write("input number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your number is " + num);
*/

// Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

/*
Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a Second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int q2 = n2 * n2;

if(n1 == q2)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
*/

// Задача 2. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

/*
Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

int current = -n;

if(n < 0)
{
    current = n;
    n = -n;
}

while(current <= n)
{
    Console.Write(current + " ");
    current++;
}
*/

//Задача 3. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

//3162 % 10 -> 2
//3162 % 100 -> 62
//3162 % 1000 -> 162

//3162 / 10 -> 316
//3162 / 100 -> 31
//3162 / 1000 -> 3

//82736 / 100 -> 827 % 100 -> 27
//5243 / 10 -> 524 % 10 -> 4

/*
Console.Write("Input a three-digit number:" );
int n = Convert.ToInt32(Console.ReadLine());

if(n >= 100 && n < 1000)
{
    int lastDigit = n % 10;
    Console.WriteLine(n % 10);
    Console.WriteLine($"last Digit of {n} is {lastDigit}");
}
else
{
    Console.WriteLine("Uncorrected input");
}
*/