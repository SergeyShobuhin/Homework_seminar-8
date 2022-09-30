// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.Write("Введите размерность массива: ");
int rowLen = Convert.ToInt32(Console.ReadLine());
int columLen = rowLen; /*дополнительная переменная для общего понимания кода*/ 

int [,] arrayOne = new int [rowLen, columLen];
int [,] arrayTwo = new int [rowLen, columLen];
var random = new Random();

// создаём 2 массива из рандомных чисел 
for (int i = 0; i < rowLen; i++)
{
    for (int j = 0; j < columLen; j++)
    {
        arrayOne[i,j] = random.Next(0, 10); 
        arrayTwo[i,j] = random.Next(0, 10); 
    }
}

int [,] prMatrix = new int [rowLen, columLen]; // создаём не заполненый массив

//перемножаем 2 массива и заполняем результатом массив prMatrix
for (int i = 0; i < rowLen; i++)
{
    for (int j = 0; j < columLen; j++)
    {
       
        for (int k = 0; k < columLen; k++)
        {
            prMatrix[i,j] = prMatrix[i,j] + (arrayOne[i,k] * arrayTwo[k,j]);
        }
        
    }
}


//печатаем массивы с результатом действий
void ShowPrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]  + "  ");
        }
        Console.WriteLine();
    }
}

//вызываем функции
Console.WriteLine("Первый массив:");
ShowPrintArray(arrayOne);
Console.WriteLine();
Console.WriteLine("Второй массив:");
ShowPrintArray(arrayTwo);
Console.WriteLine();
Console.WriteLine("Массив произведения:");
ShowPrintArray(prMatrix);
