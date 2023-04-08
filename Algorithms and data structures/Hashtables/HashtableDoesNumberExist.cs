#region does number exist in array

using System.Collections;
using System;

int[] intArray = { 5, 110, 515, 220, 25, 30 };
//finding if a number exists in this int array means search through it linearly, O(N), as you would have to search one by one, but using a hashtable, you can find out if the number is contained within the array in 1 step O(1) a constant time complexity (the best)
//so lets make the hash table
Hashtable hashedIntArray = new Hashtable
{
    { 5, true },
    { 110, true },
    { 515, true },
    { 220, true },
    { 25, true },
    { 30, true }
};

Console.WriteLine(hashedIntArray[5]); //prints true, so it does contain it
Console.WriteLine(hashedIntArray[-1]); //prints nothing, so it doesn't contain it

//a better practial idiomatic way of using this would be
if (hashedIntArray.ContainsKey(-1) == false)
    Console.WriteLine("Doesn't exist");

#endregion
