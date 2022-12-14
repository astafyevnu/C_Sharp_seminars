// mission 53/ Двумерный массив. меняем первую и посленднюю строку местами

// Console.WriteLine("Задайте массив!");
// Console.Write("Введите кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] matrix = new int[rows, columns];

// for(int i=0; i<matrix.GetLength(0); i++)
// {
//     for(int j=0; j<matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(1, 10);
//         Console.Write(matrix[i, j]+ "\t");
//     }
//     Console.WriteLine();
// }

// int[] temp = new int[matrix.GetLength(1)];

// for (int k=0; k<matrix.GetLength(1); k++)
// {
//     temp[k] = matrix[0, k];
//     matrix[0, k] = matrix[matrix.GetLength(0)-1, k];
//     matrix[matrix.GetLength(0)-1, k] = temp[k];
// }

// Console.WriteLine("Новый массив: ");

// for (int i=0; i<matrix.GetLength(0); i++)
// {
//     for (int j=0; j<matrix.GetLength(1); j++)
//     {
//         Console.Write(matrix[i, j]+ "\t");
//     }
//     Console.WriteLine();
// }


// mission 55/ Двумерный массив. меняем строки на столбцы

// Console.WriteLine("Задайте массив!");
// Console.Write("Введите кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] matrix = new int[rows, columns];

// for(int i=0; i<matrix.GetLength(0); i++)
// {
//     for(int j=0; j<matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(1, 10);
//         Console.Write(matrix[i, j]+ "\t");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Новый массив: ");

// if (matrix.GetLength(0) == matrix.GetLength(1))
// {
//     for (int i=0; i<matrix.GetLength(0); i++)
//     {
//         for (int j=0; j<matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[j, i]+ "\t");
//         }
//         Console.WriteLine();
//     }
// }
 
// else Console.WriteLine("Невозможно сделать замену.");

// mission 59/ Двумерный массив. Удалить строку и столбик, на пересечении которых расположен наименьший элемент массива

int rows = 3;
int columns = 3;
int[,] matrix = new int [rows, columns];

int minValue = int.MaxValue;
int minIndexRows = 0;
int minIndexColumns = 0;

for(int i=0; i<matrix.GetLength(0); i++)
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(11);
        Console.Write(matrix[i, j]+ "\t");
        if (minValue>matrix[i, j])
        {
            minValue=matrix[i, j];
            minIndexRows = i;
            minIndexColumns = j;
        }
    }
    Console.WriteLine();
}
Console.WriteLine("Минимум: " + minValue);
System.Console.WriteLine("Результат: ");
for(int i=0; i<rows; i++)
{
    if (i != minIndexRows)
    {
        for(int j=0; j<columns; j++)
        {
            if (j != minIndexColumns)
            {
                Console.Write(matrix[i, j]+ "\t");
            }
        }
        System.Console.WriteLine();
    }
}