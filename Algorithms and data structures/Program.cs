/*Use this file to run the code, copy paste the code from the other files
The property of the other .cs files are build action none, so they dont compile, they are just files to copy paste from into here

Complexity cheat sheet in Big O notation, from fastest to worst

============== O(1) ...........Excellent (1st Place)
public static int Multiply(int a, int b)
{
    return a * b;
}
============== O(log n) ...........Excellent (2nd Place)
for(int i = 1; i <= n; i = i * 2)
{
    Console.WriteLine("Hello");
}
============== O(n) ...........Good (3rd Place) linear
for(int i = 1; i <= n; i++)
{
    Console.WriteLine("Hello");
}

============== O(n log n) ...........Bad (4th Place)
for(int i = 0; i < n; i++)
{
    for(int j = 1; j < n; j = j * 2)
    {
        Console.WriteLine("Hello");
    }
}
============== O(n^2) ........... Horrible (5th Place)
for(int i = 0; i < n; i++)
{
    for(int j = 0; j < n; j = j + 2)
    {
        Console.WriteLine("Hello");
    }
}
============== O(2^n) ........... Horrible (6th Place)
int fibonacci(int number)
{
    if(number <= 1) return number;

    return fibonacci(number - 2) + fibonacci(number - 1);
}
============== O(n!) ........... Horrible (7th Place)
no example yet

*/

/*
int count = 0;

int fibonacci(int number)
{
    count++;
    if (number <= 1) return number;

    return fibonacci(number - 2) + fibonacci(number - 1);
}

int input = 6;
int output = fibonacci(input); 
Console.WriteLine("Input = {0}, Output = {1}, done {2} operations", input, output, count);
*/

/*
HashSet<int> set = new HashSet<int>();
set.Add(1);
set.Add(2);
set.Add(3);
set.Add(3);
set.Add(1);

foreach (int element in set)
{
    Console.WriteLine(element);
}*/

/*int binary_search(int[] array, int value)
{
    Array.Sort(array);
    int lowerBound = 0;
    int upperBound = array.Length -1;

    int count = 0;
    while (lowerBound <= upperBound)
    {
        Console.WriteLine("Loop {0}", count);
        count++;
        int middleIndex = (upperBound + lowerBound) / 2;
        int valueAtMiddleIndex = array[middleIndex];

        if (value < valueAtMiddleIndex)
            upperBound = middleIndex - 1;
        else if (value > valueAtMiddleIndex)
            lowerBound = middleIndex + 1;
        else if (value == valueAtMiddleIndex)
            return valueAtMiddleIndex;
    }
    return -1;
}

Console.WriteLine(binary_search(new int[4] { 17, 3, 202, 80 }, 3));*/