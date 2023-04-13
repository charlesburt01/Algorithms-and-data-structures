//identify common values in both arrays and return those
using System.Collections;

int[] Intersects(int[] array1, int[] array2)
{
    int[] shorterArray;
    int[] longerArray;

    if (array1.Length > array2.Length)
    {
        shorterArray = array2;
        longerArray = array1;
    }
    else if (array1.Length < array2.Length)
    {
        shorterArray = array1;
        longerArray = array2;
    }
    else
    {
        shorterArray = array1;
        longerArray = array2;
    }

    //convert the longer array to a hashtable
    Hashtable hashtable = new Hashtable();
    foreach (int number in longerArray)
    {
        hashtable[number] = true;
    }

    //Check if all numbers inside the shorterArray exist, and if so, add to a new array to return
    int[] returnedArrayIntersections = new int[0];
    int index = 0;
    for (int i = 0; i < shorterArray.Length; i++)
    {
        if (hashtable[shorterArray[i]] != null)
        {
            returnedArrayIntersections[index] = (int)hashtable[shorterArray[i]];
            index++;
        }
    }

    return returnedArrayIntersections;
}
//Intersection with O(N)
int[] array1 = new int[] { 1, 2, 3, 4, 5 };
int[] array2 = new int[] { 2, 4, 9 };

var arr = Intersects(array1, array2);

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]); // should print 2,4
}