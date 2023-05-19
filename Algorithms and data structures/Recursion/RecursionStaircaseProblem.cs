// The staircase problem
// How many possible combinations of steps can be taken to get to the top of a staircase of n steps, 
// if the person climbing can climb 1, 2 or 3 steps at a time?
using System;

int numberOfPaths(int n)
{
    if (n < 0) return 0;
    if (n == 1 || n == 0) return 1;
    return numberOfPaths(n - 1) + numberOfPaths(n - 2) + numberOfPaths(n - 3);
}
Console.WriteLine($"Expected = 1 Actual = {numberOfPaths(1)}");
Console.WriteLine($"Expected = 2 Actual = {numberOfPaths(2)}");
Console.WriteLine($"Expected = 4 Actual = {numberOfPaths(3)}");
Console.WriteLine($"Expected = 7 Actual = {numberOfPaths(4)}");