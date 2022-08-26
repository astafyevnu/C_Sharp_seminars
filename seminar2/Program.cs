// 1.

// int num = new Random().Next(10,100);
// int num1 = num/10;
// int num2 = num%10;
// int max = num1;

// if (max<num2)
// {
//     max=num2;
// }

// Console.WriteLine(num);
// Console.WriteLine(max);



// 2. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// int num = new Random().Next(100,1000);
// int num1 = num/100;
// int num2 = num%10;

// Console.WriteLine(num);


// // Console.Write(num1);
// // Console.WriteLine(num2);


// Console.WriteLine(num1*10+num2);

// 3. получаем два числа, проверяем кратны ли числа, если нет, то выводим остаток от деления

// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int result = num2%num1;
// if (result == 0)
// {
//     Console.WriteLine("Число кратно.");
// }
// else
// {
//     Console.WriteLine("Остаток от деления " + result);
// }

// 4. проверить кратность 7 и 23 одновременно 

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int num1 = 7;
// int num2 = 23;
// int result1 = num%num1;
// int result2 = num%num2;
// if (result1 == 0 && result2 == 0)
// if (num%7 == 0 && num%23 == 0) // вместо 5и верхних строк
// {
//     Console.WriteLine("Число кратно 7 и 23.");
// }
// else
// {
//     Console.WriteLine("Число не кратно одновременно 7 и 23.");
// }

// 5.

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2*num2){
    Console.WriteLine("Первое число является квадратом второго.");
}
else if (num2 == num1*num1){
    Console.WriteLine("Второе число является квадратом первого.");
}
else {
    Console.WriteLine("Числа не являются квадратами друг друга.");
}