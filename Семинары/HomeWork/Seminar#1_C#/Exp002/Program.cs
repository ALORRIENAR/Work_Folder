//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

/*
Console.Write("Введите первое число: " );
int a = Convert.ToInt32(Console.ReadLine ());

Console.Write("Введите второе число: " );
int b = Convert.ToInt32(Console.ReadLine ());

if(a > b) 
{
    Console.WriteLine("a = " + a + " b = " + b + " -> max = " + a);
}
else if (a < b)
{
    Console.WriteLine("a = " + a + " b = " + b + " -> max = " + b);
}
else
{
    Console.WriteLine ("Оба числа равны");
}
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

/*
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max)
{
    Console.WriteLine(a + ", " + b + ", "+ c +  " -> " + b );
}
else if (c > max)
{
     Console.WriteLine(a + ", " + b + ", "+ c +  " -> " + c);
}
else 
{
    Console.WriteLine(a + ", " + b + ", "+ c +  " -> " + a);
}
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

/*
Console.Write("Является ли число четным? ");
int n1 = Convert.ToInt32(Console.ReadLine());

if (n1 %2 == 0)
{
    Console.WriteLine(n1 + " -> Да");
}
else
{
    Console.WriteLine(n1 + " -> Нет");
}
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

/*
Console.Write("Input number: ");
int N = Convert.ToInt32(Console.ReadLine());
int number = 1;

    while (number <= N)
    {
        int result = number % 2;
            if (result == 1)
            {
                number++;
            }
            else
            {
                Console.WriteLine(number);
                number++;
            }
    }    
    
*/
