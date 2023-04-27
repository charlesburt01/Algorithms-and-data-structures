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

//A simpler version
int arraySumSimple(int[] array)
{
    if (array.Length == 1) return array[0];
    int[] shorterArray = new int[array.Length - 1];
    Array.Copy(array, 1, shorterArray, 0, array.Length - 1);
    return array[0] + arraySum(shorterArray);
}
Console.WriteLine("Expected = 55, actual = " + arraySumSimple(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));