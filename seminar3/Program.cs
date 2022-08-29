// bool

// int testNum = 3324;

// bool test = testNum == 3324;

// Console.WriteLine(test);

// or

// int testNum = 3324;

// Console.WriteLine(testNum = 3324);

// принимает координаты и определяет номер четверти 

// Console.WriteLine("Введите Х: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();
// if(x>0 && y>0)
// {
//     Console.WriteLine("1");
// }

// if(x<0 && y>0)
// {
//     Console.WriteLine("2");
// }

// if(x<0 && y<0)
// {
//     Console.WriteLine("3");
// }

// if(x>0 && y<0)
// {
//     Console.WriteLine("4");
// }

// if(x==0 || y==0)
// {
//     Console.WriteLine("Определить нельзя");
// }

//  показывает диапазон по четверти

// Console.WriteLine("Введите номер четверти: ");
// int x = Convert.ToInt32(Console.ReadLine());


// if(x>4 || x<1)
// {
//     Console.WriteLine("Ошибка");
// }

// if(x == 1)
// {
//     Console.WriteLine("Х от 0 до бесконечности, У от 0 до бесконечности.");
// }

// if(x == 2)
// {
//     Console.WriteLine("Х от 0 до минус бесконечности, У от 0 до бесконечности.");
// }

// if(x == 3)
// {
//     Console.WriteLine("Х от 0 до минус бесконечности, У от 0 до минус бесконечности.");
// }

// if(x==4)
// {
//     Console.WriteLine("Х от 0 до бесконечности, У от 0 до минус бесконечности.");
// }


// double x = Math.Pow(5,2);
// double i = Math.Sqrt(49);

// находит расстояние между двумя точками в 2д пространстве

// Console.WriteLine("Введите Х1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите У1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите Х2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите У2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double d=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));

// Console.WriteLine(d);

// выдает таблицу квадратов от 1 до N

// 1 sposob
// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int index = 1;
// while (index<=n)
// {
//     Console.WriteLine(Math.Pow(index,2));
//     index++;
// }

// 2 sposob
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int count=1; count<=n; count++)
{
    double result = Math.Pow(count,2);
    Console.WriteLine(result);
}
