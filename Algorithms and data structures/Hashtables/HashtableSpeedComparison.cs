
//Array subset (find out wether or not a second array is contained within the first array).
//The function below has a time complexity of O(N*M)
using System.Collections;

bool IsSubsetArrayVersion(int[] masterArray, int[] checkSubsetArray)
{
    bool foundMatch = false;
    for (int i = 0; i < checkSubsetArray.Length; i++)
    {
        foundMatch = false;
        for (int j = 0; j < masterArray.Length; j++)
        {
            if (checkSubsetArray[i] == masterArray[j])
            {
                foundMatch = true;
                break;
            }
        }
        if (foundMatch == false) return false;
    }
    return true;
}
Console.WriteLine(IsSubsetArrayVersion(new int[] { 1, 0, 3 }, new int[] { 0, 1 })); //output should be true
Console.WriteLine(IsSubsetArrayVersion(new int[] { 1, 0, 3 }, new int[] { 0, 1, 4 })); //output should be false

//The function below has a time complexity of O(N+M) or O(N) where N is the total numbers in both arrays
bool IsSubsetHashtableVersion(int[] masterArray, int[] checkSubsetArray)
{
    Hashtable masterArrayHT = new Hashtable();
    //first the array we are searching to a hashtable O(N)
    foreach (var integer in masterArray)
    {
        masterArrayHT.Add(integer, true);
    }
    for (int i = 0; i < masterArray.Length; i++)
    {
        masterArrayHT[masterArray[i]] = true;
        //masterArrayHT.Add(masterArray[i], true); //can use either this line of the one above, however the .Add method checks first to see if the value already exists for the key, and throws an exception if it does, whereas the other way overwrites the value
    }
    //second loop through the subset array to count values that exist O(M)
    for (int k = 0; k < checkSubsetArray.Length; k++)
    {
        if (masterArrayHT.ContainsKey(checkSubsetArray[k]) == false)
            return false;
    }
    return true;
}
Console.WriteLine(IsSubsetHashtableVersion(new int[] { 1, 0, 3 }, new int[] { 0, 1 })); //output should be true
Console.WriteLine(IsSubsetHashtableVersion(new int[] { 1, 0, 3 }, new int[] { 0, 1, 4 })); //output should be false