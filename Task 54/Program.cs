// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// Функция определения массива
int [,]  GetArrayRandom(int line, int column)
    {
        int[,] array = new int [line,column];
        var random = new Random();

        for (int i = 0; i < line; i++)
            {
                 for (int j = 0; j < column; j++)
                 {
                    array[i,j] = random.Next(0, 10);
                    Console.Write(array[i,j]  + "   ");
                 }
                 Console.WriteLine();
            }
            
        return array;
    }

// Функция сортировки по строкам
int[,] GetSortingArray(int [,] array)
{    
    var sortArray = array;
    for (int i = 0; i < sortArray.GetLength(0); i++)
        {
            for (int j = 0; j < sortArray.GetLength(1); j++)
                {                 
                    for (int k = j + 1; k < sortArray.GetLength(1); k++) /*j+1 для начала сравнения со второго элемента, -1 нужен что бы не сранивать с самим собой*/ 
                        {
                            if (sortArray[i, j] < sortArray[i, k])
                                {
                                    int temp = sortArray[i, j];
                                    sortArray[i, j] = sortArray[i, k];
                                    sortArray[i, k] = temp;
                                }
                        }
                    Console.Write(sortArray[i, j] + "  ");    
                }
            Console.WriteLine();
        }
 
    return sortArray;
}

//Задаём массив
Console.Write("Введите размер массива N: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер массива M: ");
int column = Convert.ToInt32(Console.ReadLine());

//Вызов функций
var array = GetArrayRandom(line, column);
Console.WriteLine("Массив по убыванию элементов в строке");
var sortArray = GetSortingArray(array);

