//Insertion Sort

using System;

int[] InsertionSort(int[] array)
{
    //start at the second cell in the array, and run forward through each cell, until reaching the end
    for (int i = 1; i < array.Length; i++)
    {
        //cache the current cell's value, from the outer loop
        //this value increases
        int i_leadingPositionValue = array[i];
        //cache the previous cell's value
        //this value decreases
        int d_cellIndexBefore = i - 1;

        //this while loop has 2 exit parameters
        //only run until positionbefore reaches leftmost value
        //run backwards from the position before
        while (d_cellIndexBefore >= 0)
        {
            //if the value at the position before is greater than the leading position
            if (array[d_cellIndexBefore] > i_leadingPositionValue)
            {
                //shift or move the value forward
                array[d_cellIndexBefore + 1] = array[d_cellIndexBefore];
                //then look at the next position before
                d_cellIndexBefore--;
            }
            //if the value at the position before isn't greater than the leading position, jump out of the while loop
            else
            {
                break;
            }
        }
        //by this time we have found the correct position for the leadingPosition, and moved everything forward, so now we insert it in its proper place
        array[d_cellIndexBefore + 1] = i_leadingPositionValue;
    }
    return array;
}

int[] arr = new int[] { 4, 2, 7, 1, 3 };// 2, 4, 7, 1, 3 // 2, 4, 1, 7, 3 // 2, 1, 4, 7, 3 /// 1, 2, 4, 7, 3 /// 1, 2, 4, 3, 7 ///  1, 2, 4, 3, 7///  1, 2, 3, 4, 7
arr = InsertionSort(arr);
string output = "";

for (int i = 0; i < arr.Length; i++)
{
    output += arr[i];
}
Console.WriteLine(output);