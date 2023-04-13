//Function that accepts an array of strings, and returns the first duplicate value it finds.
//Assuming there is always 1 pair of duplicates per array
//["a", "b", "c", "c"] would return "c"

//return duplicate string
using System.Collections;

string GetDuplicate(string[] stringArray)
{
    //what do we have to do to check for duplicates?
    //well a hashtable's key can be a string, much like an array's index is a number
    //once an item is inserted into the hashtable at the "key" which is the index, 
    //if we lookup the hashtable via the key, it will return null, if nothing is there
    //however if something is already at that key, or it is not null, we know we have 
    //already encountered that key before.
    Hashtable copy = new Hashtable();
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (copy[stringArray[i]] != null)
            return stringArray[i];

        copy[stringArray[i]] = true; //warning: adding to a hashtable by value won't insert a duplicate, it will overwrite the value
    }
    return "not found any duplicates";
}
Console.WriteLine(GetDuplicate(new string[] { "a", "b", "c", "c" })); // should return c