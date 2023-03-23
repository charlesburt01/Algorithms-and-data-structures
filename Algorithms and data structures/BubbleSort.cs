//Bubble Sort Code Implementation
int[] ListToSort = new int[] { 4, 2, 7, 1, 3 };

int[] BubbleSort(int[] list)
{
    bool sorted = false;
    int unsortedUntil = list.Length - 1;

    while (!sorted)
    {
        sorted = true;
        for (int i = 0; i < unsortedUntil; i++)
        {
            if (list[i] > list[i + 1])
            {
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
Console.WriteLine(list);