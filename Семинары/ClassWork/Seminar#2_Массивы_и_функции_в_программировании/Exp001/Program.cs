/*
int FindBiggerDigit(int num)

{
    int result;
//Логическое "или" || логическое ''и'' && два комперсанта
    if(num < 10 || num >=100) 
        return 0;
    else
    {
        int ed = num  % 10;
        int dec = num / 10;
        
        if (ed > dec)
            result = ed;
        else
            result = dec;
    }
//Команда return, когда команда доходит до return, она завершает работу метода, берет значение, которое мы указываем и возращает ее в то место, где метод был вызван в нашем случае в 25-ой строчке int biggerDigit = FindBiggerDigit(number);
    return result; 
}

Console.Write("Введите двухзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int biggerDigit = FindBiggerDigit(number);
Console.WriteLine($"Bigger digit of {number} is {biggerDigit}");
*/

//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*
int TreeDigitNumber (int num)
{
    int ed = num % 10;
    int dec = num / 100;
    int result = dec * 10 + ed;
    return result;
}

int number = new Random().Next(100, 1000);
Console.WriteLine(number);
Console.WriteLine(TreeDigitNumber(number));
*/

//Напишите программу, которая принимает на вход число n и проверяет, кратно ли оно одновременно a и b(целочисленные делители, также задаются пользователем).
bool number(int num1, int num2, int num3)
{
 if (num1 % num2 == 0 && num1 % num2 == 0)
    return true;
else
    return false;
}

Console.Write("Введите кратное число: ");
int MultipleNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите первый делитель: ");
int dividerNumberOne = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второй делитель: ");
int dividerNumberTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Ответ: {number(MultipleNumber, dividerNumberOne, dividerNumberTwo)} ");







