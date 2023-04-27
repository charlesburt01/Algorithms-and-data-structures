//Recursion top down factorial
using System;

int factorial(int number)
{
    if (number == 1)
        return 1;
    else
        return number * factorial(number - 1);
}
Console.WriteLine("expected = 6, actual = " + factorial(3));