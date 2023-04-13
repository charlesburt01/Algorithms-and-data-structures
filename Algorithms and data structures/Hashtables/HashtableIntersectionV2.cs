using System.Collections;

int[] IntersectionLinear(int[] array1, int[] array2)
{
    //arrange the arrays into shorter or longer
    int[] shorterArray, longerArray;
    if (array1.Length > array2.Length) { shorterArray = array2; longerArray = array1; }
    else if (array2.Length > array1.Length) { shorterArray = array1; longerArray = array2; }
    else { shorterArray = array1; longerArray = array2; }

    //stuff the longer array into a hashtable
    Hashtable longerArrayHT = new Hashtable();
    foreach (int num in longerArray) //================= O(N)
    {
        longerArrayHT.Add(num, true);
    }
    List<int> returnedArray = new List<int>();

    //loop through the shorter array
    for (int i = 0; i < shorterArray.Length; i++) //================= O(M) or O(N) if N = total numbers in both arrays
    {
        //check hashtable for value, if value exists, add it to the returned array
        if (longerArrayHT.ContainsKey(shorterArray[i]))
        {
            returnedArray.Add(shorterArray[i]);
        }
    }
    return returnedArray.ToArray(); //================= O(L) the new, smaller array
    //=================TOTAL = O(N + M + L), e.g. (5+10+3), so dropping constants, would leave O(N), N being total number of numbers
}

int[] array1 = new int[] { 1, 2, 3, 4 };
int[] array2 = new int[] { 0, 0, 3 };
int[] array3 = new int[] { 1, 2, 3, 0 };

Console.WriteLine(IntersectionLinear(array1, array2).Length);//should print 1

string numbers = "";
int[] result = IntersectionLinear(array1, array3);
for (int i = 0; i < result.Length; i++)
{
    numbers += result[i];
}
Console.WriteLine(numbers); // should print 1,2,3