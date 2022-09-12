// mission 46/ двумерный массив, заполненный случ. цел. числами

// int rows = Convert.ToInt32(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] matrix = new int[rows, columns];

// for(int i=0; i<matrix.GetLength(0); i++)
// {
//     for(int j=0; j<matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(0, 11);
//         Console.Write(matrix[i, j] + "\t");
//     }
//     Console.WriteLine();
// }

//  mission 48 / двумерный массив m*n, где каждый элемент по формуле Amn = M + N

// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int rows = int.Parse(Console.ReadLine());
// int columns = int.Parse(Console.ReadLine());

// int [,] matrix = new int[rows, columns];

// for(int i=0; i<rows; i++)
// {
//     for(int j=0; j<columns; j++)
//     {
//         matrix[i, j] = i + j;
//         Console.Write(matrix[i, j] + "\t");
//     }
//     Console.WriteLine();
// }

//  mission 49/ элементы с обоими четными индексами заменить на квадрат


// int rows = Convert.ToInt32(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());

// double [,] matrix = new double[rows, columns];

// for(int i=0; i<rows; i++)
// {
//     for(int j=0; j<columns; j++)
//     {
//         matrix[i, j] = new Random().Next(0, 10);
//         if(i%2 == 0 && j%2 == 0)
//         {
//             matrix[i, j] = Math.Pow(matrix[i, j], 2);
//         }
//         Console.Write(matrix[i, j] + "\t");
//     }
//     Console.WriteLine();
// }

//  mission 51/ найти сумму элементов наход. на главн. диагонали массива

int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int[rows, columns];
int sum = 0;
for(int i=0; i<rows; i++)
{
    for(int j=0; j<columns; j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        if(i == j)
        {
            sum +=matrix[i, j];
        }
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine(sum);