//Bubble Sort Code Implementation
//this is actually n^2 because of the comparisons and swaps, there are extra steps to take into accouunt, not just looking at the nested loops
using System;

//int[] ListToSort = new int[] { 5, 4, 3, 2, 1 }; // making the array the worst case possible
int[] ListToSort = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };// making the array the worst case possible
int steps = 0;

int[] BubbleSort(int[] list)
{
    bool sorted = false;
    int unsortedUntil = list.Length - 1;

    while (!sorted)
    {
        sorted = true;
        for (int i = 0; i < unsortedUntil; i++)
        {
            steps++; // adding a step for the comparison below
            if (list[i] > list[i + 1])
            {
                steps++;//adding a step for the swaps below
                int n = list[i];
                int n1 = list[i + 1];
                list[i] = n1;
                list[i + 1] = n;
                sorted = false;
            }
        }
        unsortedUntil--;
    }

    return list;
}

int[] sortedList = BubbleSort(ListToSort);
string list = "";
for (int i = 0; i < sortedList.Length; i++)
{
    list += sortedList[i].ToString();
}
Console.WriteLine("List = " + list + " List Length = " + sortedList.Length + " Steps = " + steps);
