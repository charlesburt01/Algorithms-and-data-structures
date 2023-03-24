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

//===================Optimising Functions Example==========================

//Speeding up functions, alarm bells should be ringing if the function is O(N^2) or above.
//Example of the nested loop function we should optimize, first we identify that it has a time complexity of O(N^2)
//which is a slow function, that gets slower as the data increases.

int steps = 0;
//Slow function
bool HasDuplicateValue(int[] array)
{
    steps = 0;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length; j++)
        {
            steps++;
            if(i != j && array[i] == array[j])
                return true;
        }
    }
    return false;
}
//Lets use an array with no duplicates so that we get the worst case scenario for the function
int[] arrayWithNoDuplicates = new int[] { 0, 6, 1, 2, 4 };
bool hasDuplicates = HasDuplicateValue(arrayWithNoDuplicates);
Console.WriteLine("Array size = " + arrayWithNoDuplicates.Length + ". Steps taken = " + steps + ". Has Duplicates = " + hasDuplicates);

//Optimised version



//===================End Optimising Functions Example======================
