// // массив и суммы чисел. Задача 31

// int [] array = new int [12];
// int size = array.Length;

// int positiveSum = 0;
// int negativeSum = 0;

// for(int i = 0; i<size; i++)
// {
//     array[i] = new Random().Next(-9, 10);

//     if(array[i]>0) positiveSum+=array[i];
//     else negativeSum+=array[i];
// }



// Console.WriteLine("Сумма положительных чисел = " + positiveSum + " | Сумма отрицательных чисел = " + negativeSum);
// Console.WriteLine(String.Join(";", array));

// задача 37. Произведение пар чисел в одномерном массиве. [1 2 3 4 5] -> 5 8 3

// int [] inputArray = {1,2,3,4,5};;
// int index = inputArray.Length;

// int [] resultArray = new int [inputArray.Length/2 + inputArray.Length%2];

// for(int i = 0; i<resultArray.Length; i++)
// {
//     resultArray[i] = inputArray[i]*inputArray[inputArray.Length-1-i];

//     if(i == inputArray.Length-1-i)
//     {
//         resultArray[i] = inputArray[i];
//     }
// }
// Console.WriteLine(String.Join (",", resultArray));

// заменяет положительные элементы массива на отрицательный и наоборот

// int [] array = {-4, -8, 7, 2};
// for(int i = 0; i<array.Length; i++) array[i]*=-1;

// Console.WriteLine("[{0}]", String.Join (",", array));



// находит число в массиве
// way1
// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] array =  new int [size];
// for(int i=0; i<size; i++) array[i] = new Random().Next(-9, 10);

// Console.WriteLine("[{0}]", String.Join (",", array));


// Console.Write("Введите искомое число: ");
// int necessaryNum = Convert.ToInt32(Console.ReadLine());

// int count = 0;
// for(int i=0; i<size; i++)
// {
//     if(array[i] == necessaryNum) count++;
// }
// if (count > 0) Console.WriteLine($"Это число найдено в кол-ве: {count}.");

// waY2

// Console.Write("Введите искомое число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string result = "no";
// int [] array = {6, 7, 19, 345, 3};
// for(int i=0; i<array.Length; i++)
// {
//     if(array[i] == num) result = "Yes";
// }
// Console.Write(result);