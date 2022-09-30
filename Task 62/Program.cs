// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


//задаём начальные значения
int size = 5;
int counter = 1;
int startColumn = 0;
int endColumn = size - 1;
int startRow = 0;
int endRow = size - 1;
var result = new int[size, size];

while (startColumn <= endColumn && startRow <= endRow)
{
    // шагаем по столбцам
    for (int i = startColumn; i <= endColumn; i++) 
    {
        result[startRow, i] = counter;
        counter++;
    }
    startRow++;

    //шагаем по строкам
    for (int j = startRow; j <= endRow; j++)
    {
        result[j, endColumn] = counter;
        counter++;
    }
    endColumn--;

    // шагаем по столбцам
    for (int i = endColumn; i >= startColumn; i--)
    {
        result[endRow, i] = counter;
        counter++;
    }
    endRow--;

    // шагаем по строкам
    for (int i = endRow; i >= startRow; i--)
    {
        result[i, startColumn] = counter;
        counter++;
    }
    startColumn++;

}


//вывод на экран результата
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {

        Console.Write($"{result[i, j]} ");
    }
    Console.WriteLine();

}