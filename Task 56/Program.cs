// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


/*************
// не сравнивает суммы
// не выводит счетчик строк
**************/

// Функция определения массива
int[,] GetArrayRandom(int line, int column)
{
    int[,] array = new int[line, column];
    var random = new Random();

    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = random.Next(0, 10);
            Console.Write(array[i, j] + "   ");
        }
        Console.WriteLine();
    }

    return array;
}


int GetArithmeticArrayСolumn(int[,] array)
{

    int currentSum = 0;
    int minSum = 0;
    int indexMin = 0;

    for (int i = 0; i < array.GetLength(0); i++) //Строки
    {
        currentSum = 0;
        for (int j = 0; j < array.GetLength(1); j++) //Столбцы
        {
            currentSum = currentSum + array[i, j];
        }
        Console.Write(currentSum + " ");

        if (i == 0 || currentSum < minSum)
        {
            minSum = currentSum;
            indexMin = i;
        }



    }

    return indexMin + 1;

}



//Задаём массив
Console.Write("Введите размер массива N: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер массива M: ");
int column = Convert.ToInt32(Console.ReadLine());

//Вызов функций
var array = GetArrayRandom(line, column);
Console.WriteLine("Cреднее арифметическое столбцам:");
int sumAA = GetArithmeticArrayСolumn(array);

Console.WriteLine($"Строка с наименьшей суммой элементов: {sumAA}");

