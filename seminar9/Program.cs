// mission 63/ выводим все натур числа в промеж от 1 до n

// Console.Write("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// string NaturalToN (int i, int n)
// {
//     if (i <= n) return $"{i} "+ NaturalToN(i+1, n);
//     else return string.Empty;
// } 
// Console.WriteLine(NaturalToN(i, n));

//  mission / выввести натуральные числа в промежутке M - N

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// string NaturalToN (int m, int n)
// {
//     if (m <= n) return $"{m} "+ NaturalToN(m+1, n);
//     else return string.Empty;
// } 
// Console.WriteLine(NaturalToN(m, n));

//  mission 67/ возвращаем сумму цифр числа

// int n = 323;
// int SumNumber (int n)
// {
//     if (n == 0) return 0;
//     return (n%10 + SumNumber(n/10));
// } 
// Console.WriteLine(SumNumber(n));

//  mission 69/ принимает A и B, а выводит A в целой степени B 

Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число В: ");
int b = Convert.ToInt32(Console.ReadLine());

int PowerNumber (int a, int b)
{
    if (b == 0) return 1;
    return a * PowerNumber(a, b-1);
} 
Console.WriteLine(PowerNumber(a, b));
