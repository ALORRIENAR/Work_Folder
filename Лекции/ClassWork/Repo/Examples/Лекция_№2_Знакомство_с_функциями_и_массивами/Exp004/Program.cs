//для заполнения случайными другими числами используем метод:
//collectiom - название  функции/метода.
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

//Метод который будет печатать массив: 
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int [] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    //Ставим значение -1, если в массиве не будет элемента соответсвущего поиска к примеру [массив состоит из 3 элементов числа 1, 12, 14], а в запросе  будет число 123, то оператор вернет index 0 int pos = IndexOf(array, 213);
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

//По какой-то причине мы снесли на 6-ю строчку, и по умолчанию он будет наполнен нулями.
//Создание нового массива в котором будет 10 элемнтов new int [10]; 
//Что сделали ? 1.Определили массив из 10-ти элементов
int [] array = new int [10];

//2. Вызвали метод FillArray, который заполнил массив
FillArray(array);
//Пренудительное добавление элементов.
array[4] = 4;
array[6] = 4;
//3. вызываймый метод вывел в терминал ''array''
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);