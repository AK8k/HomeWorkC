
//Задача 1

/*
Console.WriteLine("Input number: ");

int number;

number = Convert.ToInt32(Console.ReadLine());

int Qad = number * number;


Console.WriteLine("Qad of " + number + " is " + Qad);
*/
// Console.WriteLine($"Qad of {number} is {Qad}");

/*if (number > 0)
{
    Console.WriteLine(number + "is positive!");
}

Console.WriteLine("Qad mumber " + number + "is" + Qad);

*/

// Является ли первое число квадратом второго
/*
Console.WriteLine("Enter first number: ");

int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");

int number2 = Convert.ToInt32(Console.ReadLine());

int quad = number2 * number2;

if (number1 == quad)
{
    Console.WriteLine("first numb is quad second number");
}

else
{
    Console.WriteLine("first numb not quad second number");
}

*/



//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.


/*
Console.WriteLine("Введите число N");

int N = Convert.ToInt32(Console.ReadLine());

int current = 0 - N;

while (current <= N)

{
    
    Console.WriteLine(current);
    current++;
}


*/





/*

Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

/*
Console.WriteLine("Enter first number: ");

int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");

int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)

{
    Console.WriteLine("max numb " + number1);
    Console.WriteLine("min numb " + number2);
}

if (number1 < number2)

{
    Console.WriteLine("max numb " + number2);
    Console.WriteLine("min numb " + number1);
}

if (number1 == number2)

{
    Console.WriteLine("all numb " + number1);
}

*/

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

*/
/*
Console.WriteLine("Enter first number: ");

int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");

int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third number: ");

int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (max < number2)
{
    max = number2;
}


if (max < number3)

{
    max = number3;
}

Console.WriteLine("max numb is " + max);
*/




/*

Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

*/
/*
Console.WriteLine("Enter number: ");

int num = Convert.ToInt32(Console.ReadLine());

int m = num % 2;

if (m == 0)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}

*/


/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8

*/
/*
Console.WriteLine("Введите число N");

int N = Convert.ToInt32(Console.ReadLine());

int current = 1;

while (current <= N)

{

    int m = current % 2;

    if (m == 0 && current > 1)
    {
        Console.WriteLine(current);
    }

    current++;
}
*/


/*


*/
