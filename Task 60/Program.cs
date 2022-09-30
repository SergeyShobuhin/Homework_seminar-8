// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int size = 2; // опредеяем размер в 2 числа
var doubleNumericArray = new int[size, size, size];

var random = new Random();

var arrRandom = new int[size * size * size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {

            //проверка на экслюзивность числа

            int randElement = 0;
            bool existFlag = true;
            while (existFlag)
            {
                randElement = random.Next(10, 18); // 8 чисел для наглядного результата
                existFlag = false;

                if (arrRandom.Contains(randElement))
                {
                    existFlag = true;

                }
            }

            //заполняем раномными не повторяющимися числами пустые ячейки массива
            doubleNumericArray[i, j, k] = randElement;

            for (int m = 0; m < arrRandom.Length; m++)
            {
                // Console.WriteLine(randElement);
                // Console.Write($" {m} -- {arrRandom[m]   }");
                if (arrRandom[m] == 0)
                {
                    arrRandom[m] = randElement;
                    break;
                }
            }
            // Console.WriteLine();
        }
    }
}


//вывод на экран результата
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            Console.Write($"{doubleNumericArray[i, j, k]} ({i},{j},{k}) ");
        }
        Console.WriteLine();
    }
}