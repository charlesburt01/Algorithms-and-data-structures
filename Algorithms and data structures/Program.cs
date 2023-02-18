
int count = 0;
int searchTerm = 51;

int[] list = new int[100];

for (int i = 0; i < 100; i++)
{
        list[i] = i;
}

int findNumber(int[] collection, int start, int end, int searchTerm)
{
    count++;
    int dynamicMiddle = start + (end - start) / 2;
    bool IsMiddle = searchTerm == collection[dynamicMiddle];
    bool OnRightSide = searchTerm > collection[dynamicMiddle];
    bool OnLeftSide = searchTerm < collection[dynamicMiddle];

    string side = "";
    if (OnRightSide) side = "right"; if (OnLeftSide) side = "left";

    Console.WriteLine("Start {0}, End {1}, Middle {2}, {3}", start, end, dynamicMiddle, side);

    if (IsMiddle){ Console.WriteLine("IsMiddle!!"); return collection[dynamicMiddle];}

    if (OnRightSide) return findNumber(collection, dynamicMiddle + 1, end, searchTerm);

    if (OnLeftSide) return findNumber(collection, start, dynamicMiddle - 1, searchTerm);

    return -1;
}
Console.WriteLine("Search Term = " + searchTerm);
long startTime = System.DateTime.Now.Millisecond;

int termFound = findNumber(list, 0, list.Length, searchTerm);

long endTime = System.DateTime.Now.Millisecond;

Console.WriteLine("Term found = " + termFound + "\nTime taken = " + (endTime - startTime) + " m.\nFunction calls = " + count);

/*int count = 0;
int findNumber(int[] collection, int start, int end, int x)
{
    count++;
    if(end >= start)
    {
        int middle = start + (end - start) / 2;
        if (collection[middle] == x)
            return middle;
        if(collection[middle] > x)
            return findNumber(collection, start, middle - 1, x);
        return findNumber(collection, middle + 1, end, x);
    }
    return -1;
}


int[] numberCollection = new int[1000000];
for (int i = 0; i < numberCollection.Length; i++)
{
    numberCollection[i] = i;
}

long startTime = System.DateTime.Now.Millisecond;

findNumber(numberCollection, 0, numberCollection.Length, 999999);

Console.WriteLine("We found the value at " + count + " try");
long endTime = System.DateTime.Now.Millisecond;
Console.WriteLine("Total time is " + (endTime-startTime).ToString() + " ms");*/