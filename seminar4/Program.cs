// возвращает сумму чисел от 0 до N

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Сумма = " + GetSum(num));


// int GetSum(int number)
// {
//     int sum =0;
//     int count =0;

//     while(number>count)
//     {
//         count++;
//         sum+=count;
//     }
//     return sum;
// }

//  возвращает кол-во цифр в числе
// way 1
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string result = Convert.ToString(num);
// Console.WriteLine("Кол-во цифр = " + NumberOfDigit(result));

// int NumberOfDigit (string num)
// {
//     int size=num.Length;
//     return size;
// }

// way 2

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Кол-во цифр = " + GetCount(num));

// int GetCount(int number)
// {
//     int count = 0;
//     while(number>0)
//     {
//         count++;
//         number/=10;
//     }
//     return count;
// }

// Возвращает произведение чисел от 1 до N
// way 1
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(num + " -> " + ProductOfNumbers(num));

// int ProductOfNumbers(int number)
// {
//     int product = 1;
//     int count = 0;
//     while(number>count)
//     {
//         count++;
//         product*=count;
//     }
//     return product;
// }

// Way 2
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int ProductOfNumbers(int num)
// {
//     int product = 1;
//     for(int count = 1; count <= num; count++)
//     {

//         product*=count;
//     }
//     return product;
// }
// Console.WriteLine(num + " -> " + ProductOfNumbers(num));






// выводит массив из 8 эл., заполн. 0 и 1 рандомно
// way 1

// int [] array = new int[8];

// // zapolnyem massiv
// void FillArray(int[] collection){
//     int lenght = collection.Length;
//     int index = 0;
//     while(index<lenght) {
//         collection[index] = new Random().Next(0, 2);
//         index++;
//     }
// }

// // vivodim massiv
// void PrintArray(int[] col){
//     int count = col.Length;
//     int position = 0;
//     while(position<count) {
//         Console.Write(col[position]);
//         position++;
//     }
// }

// FillArray(array);
// PrintArray(array);

// way 2

// int [] array = GetArray(8);
// Console.WriteLine(String.Join(",", array));
// int [] GetArray(int size)
// {
//     int[] result = new int [size];
//     for(int i=0; i<size; i++)
//     {
//         result[i] = new Random().Next(0, 2);

//     }
//     return result;
// }