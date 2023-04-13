// // Задача 2 - программа, которая по результатам ввода 2 чисел определяет какое большее, какое меньшее

// Console.WriteLine("введите число a: ");
// int a=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите число b: ");
// int b=Convert.ToInt32(Console.ReadLine());

// if (a>b) 
// {
//   Console.WriteLine("Большее число a.");
// }
// else if (a<b)
// {
//   Console.WriteLine("Большее число b.");
// }
// else if (a==b)
// {
//   Console.WriteLine("Числа a и b равны.");
// }
//////////////////////////////////////////////////////////////
//  //Задача 4 - программа из 3 чисел выбирает большее


// Console.WriteLine("Программа определяет какое число больше из 3-х (числа разные). введите число №1: ");
// int a=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число №2: ");
// int b=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число №3: ");
// int c=Convert.ToInt32(Console.ReadLine());

// if (a>b && a>c) 
// {
//   Console.WriteLine("Большее число № 1.");
// }
// else if (b>a && b>c)
// {
//   Console.WriteLine("Большее число № 2.");
// }
// else if (c>a && c>b)
// {
//   Console.WriteLine("Большее число № 3.");
// }
//////////////////////////////////////////////////////////////
// // Задача 6 - программа проверяет четность числа

// Console.WriteLine("Программа проверяет четность числа. Введите число: ");
// int a=Convert.ToInt32(Console.ReadLine());

// int b=a%2;
// if (b==0) 
// {
//   Console.WriteLine("число четное");
// }
// else
// {
//   Console.WriteLine("число нечетное");
// }
//////////////////////////////////////////////////////////////
// Задача 8 - программа запрашивает число и запрашивает все четные от 0 до этого числа

Console.WriteLine("Введите число: ");
int a=Convert.ToInt32(Console.ReadLine());
int number=2;

while (number<=a)
{
    Console.WriteLine(number);
    number=number+2;
}


//////////////////////////////////////////////////////////////

// // Эта задачка со звездочкой - прога ввести число -Т и вывести от -Т до Т

// Console.WriteLine("введите отрицательное число");

// int number=Convert.ToInt32(Console.ReadLine());
// int negNumber=number;
// number=-number;

// while (number>=negNumber)
// {
// Console.WriteLine(negNumber);
// // negNumber=negNumber+1
// negNumber++;
// }




