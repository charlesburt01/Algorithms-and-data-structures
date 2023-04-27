//recursively (top down) add all numbers inside an array
using System;

int arraySum(int[] array, int sum = 0)
{
    sum = array[0] + array[1];
    if (array.Length <= 2) return sum;
    int[] shorterArray = new int[array.Length - 2];
    Array.Copy(array, 2, shorterArray, 0, array.Length - 2);
    return sum + arraySum(shorterArray);
}
Console.WriteLine("Expected = 55, actual = " + arraySum(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
