int binary_search(int[] array, int value)
{
    Array.Sort(array);
    int lowerBound = 0;
    int upperBound = array.Length - 1;

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

Console.WriteLine(binary_search(new int[4] { 17, 3, 202, 80 }, 3));