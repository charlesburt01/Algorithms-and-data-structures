//Selection Sort N^2
//this is described as N^2 even though its more accurately N^2 / 2 and faster than the Bubble Sort algo, which is spot on N^2
//this is because the categories of Big O are so vastly different that it doesn't matter what the constants are.
//however when 2 algos come under the same classification of Big O, then we should look at them in more detail, so that we can identify which one to use, as one could be 100 times faster than the other.
using System;

int steps = 0;

int[] SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int lowestNumberIndex = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            steps++; //adding a step for the comparison
            if (array[j] < array[lowestNumberIndex])
                lowestNumberIndex = j;
        }
        steps++; //adding a step for the comparison
        if (lowestNumberIndex != i)
        {
            //adding a step for the swap
            int temp = array[i];
            array[i] = array[lowestNumberIndex];
            array[lowestNumberIndex] = temp;
        }
    }
    return array;
}
//worst case arrays
int[] sortedArray = SelectionSort(new int[] { 5, 4, 3, 2, 1 });
//int[] sortedArray = SelectionSort(new int[] { 10,9,8,7,6,5,4,3,2,1});
string str = "";

for (int i = 0; i < sortedArray.Length; i++)
{
    str += sortedArray[i].ToString();
}
Console.WriteLine("Sorted Array = " + str + " Sorted Array Length = " + sortedArray.Length + " Steps = " + steps);