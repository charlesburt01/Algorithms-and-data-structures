//Selection Sort
int[] SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int lowestNumberIndex = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[lowestNumberIndex])
                lowestNumberIndex = j;
        }
        if (lowestNumberIndex != i)
        {
            int temp = array[i];
            array[i] = array[lowestNumberIndex];
            array[lowestNumberIndex] = temp;
        }
    }
    return array;
}

int[] sortedArray = SelectionSort(new int[] { 1, 6, 3, 6, 3 });
string str = "";

for (int i = 0; i < sortedArray.Length; i++)
{
    str += sortedArray[i].ToString();
}
Console.WriteLine(str);