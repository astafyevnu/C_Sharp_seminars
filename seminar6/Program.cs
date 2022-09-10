// перевернет одномерный массив

// int[] array = GetArray(10, 0, 10);
// Console.WriteLine(String.Join(", ", array));

// ReversArray(array);
// Console.WriteLine(String.Join(", ", array));

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[ size];
//     for(int i = 0; i<size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return res;
// }

// void ReversArray(int [] inArray)
// {
//     for (int i=0; i<inArray.Length/2; i++)
//     {
//         int k = inArray[i];
//         inArray[i] = inArray[inArray.Length-1-i];
//         inArray[inArray.Length-1-i] = k;
//     }
// }

// mission 40. принимает три числа и проверяет, может ли существовать треугольник со сторонами такой длины.

// нужно допилить

// int [] array = new int [3];
// int size = array.Length;

// for(int i = 0; i<size; i++) array[i] = new Random().Next(0, 100);

// Console.WriteLine(String.Join(";", array));

// if(array[0]*array[1]*array[2] != 0) Console.WriteLine("Треугольник со сторонами такой длины существует.");
    
// else Console.WriteLine("Треугольник со сторонами такой длины не существует.");


// way 2

// Console.WriteLine("Введите стороны треугольника(a, b, c): ");
// double num1 = Convert.ToDouble(Console.ReadLine());
// double num2 = Convert.ToDouble(Console.ReadLine());
// double num3 = Convert.ToDouble(Console.ReadLine());

// void CheckTriangle(double a, double b, double c)
// {
//     if(a<b+c && b<a+c && c<a+b) Console.WriteLine("Треугольник со сторонами такой длины существует.");
//     else Console.WriteLine("Треугольник со сторонами такой длины не существует.");
// }
// CheckTriangle(num1, num2, num3);

// mission 42/ преобразовать десятичное число в двоичное

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int res = 0;

// while(num !=0)
// {
//     int value = 6;
//     string binary = Convert.ToString(value, 2);
//     // int res = num%2 +num;
//     // int num = num/2;
// }
// Console.WriteLine("Введите число: ");


// Console.WriteLine("Введите число: ");
// int value = Convert.ToInt32(Console.ReadLine());

// string binary = Convert.ToString(value, 2);

// Console.WriteLine(binary);

// way 2

// void ConvertNum(int number)
// {
//     string resalt = "";
//     while(number>0)
//     {
//         resalt = number%2+resalt;
//         number/=2;
//     }
//     Console.WriteLine(resalt);
// }

// int input = Convert.ToInt32(Console.ReadLine());

// ConvertNum(input);



// mission 44/ вывести первые N чисел Фибоначчи, не использую рекурсию


// Console.Write("Введите число n: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[number];
// array[0] = 0;
// array[1] = 1;
// for (int i = 2; i < number-1; i++)
// {
//     array [i+1] = array[i] + array [i-1];
//     Console.Write(array[i+1]+ " ");
// }



// way 2

Console.Write("Введите число n: ");
int number = Convert.ToInt32(Console.ReadLine());

int fnum = 0;
int snum = 1;
Console.Write(fnum);
Console.Write(", " +snum);
for(int i = 3; i<=number; i++)
{
    int newNum=fnum+snum;
    Console.Write(", " + newNum);
    fnum=snum;
    snum=newNum;
}
