/*Use this file to run the code, copy paste the code from the other files
The property of the other .cs files are build action none, so they dont compile, they are just files to copy paste from into here

Complexity cheat sheet in Big O notation, from fastest to worst

============== O(1) ...........Excellent (1st Place)
public static int Multiply(int a, int b)
{
    return a * b;
}
============== O(log n) ...........Excellent (2nd Place)
for(int i = 1; i <= n; i = i * 2)
{
    Console.WriteLine("Hello");
}
============== O(n) ...........Good (3rd Place) linear
for(int i = 1; i <= n; i++)
{
    Console.WriteLine("Hello");
}

============== O(n log n) ...........Bad (4th Place)
for(int i = 0; i < n; i++)
{
    for(int j = 1; j < n; j = j * 2)
    {
        Console.WriteLine("Hello");
    }
}
============== O(n^2) ........... Horrible (5th Place)
for(int i = 0; i < n; i++)
{
    for(int j = 0; j < n; j = j + 2)
    {
        Console.WriteLine("Hello");
    }
}
============== O(2^n) ........... Horrible (6th Place)
int fibonacci(int number)
{
    if(number <= 1) return number;

    return fibonacci(number - 2) + fibonacci(number - 1);
}


*/



int count = 0;
int[] list = new int[1000000000];
int searchTerm = list.Length - 1;

for (int i = 0; i < list.Length; i++)
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

    if (IsMiddle) { Console.WriteLine("IsMiddle!!"); return collection[dynamicMiddle]; }

    if (OnRightSide) return findNumber(collection, dynamicMiddle + 1, end, searchTerm);

    if (OnLeftSide) return findNumber(collection, start, dynamicMiddle - 1, searchTerm);

    return -1;
}
Console.WriteLine("Search Term = " + searchTerm);
long startTime = System.DateTime.Now.Millisecond;

int termFound = findNumber(list, 0, list.Length, searchTerm);

long endTime = System.DateTime.Now.Millisecond;

Console.WriteLine("Term found = " + termFound + "\nTime taken = " + (endTime - startTime) + " m.\nFunction calls = " + count);