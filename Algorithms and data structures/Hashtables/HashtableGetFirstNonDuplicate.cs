//returns the first non duplicated character in a string
//e.g. "minimum" would return "n" as its non duplicated and the first character

//For each duplicate (using add to hashtable), we can increment the value, otherwise set it to 1

using System.Collections;

char? GetFirstNonDuplicate(string inputString)
{
    Hashtable inputStringHashed = new Hashtable();
    foreach (char letter in inputString) //=========== O(N)
    {
        if (inputStringHashed.ContainsKey(letter) && inputStringHashed[letter] is int)
        {
            inputStringHashed[letter] = (int?)inputStringHashed[letter] + 1; //note that we can't directly increment an object type, and also note that when we cast the inputStringHashed to an int, we have to make it a nullable int? as the unboxing process could return a null value
        }
        else
            inputStringHashed[letter] = 1;
    }
    foreach (char letter in inputString) //=========== O(N)
    {
        if ((int?)inputStringHashed[letter] == 1)
            return letter;
    }
    return null;
}//=================================================TOTAL = O(N+N) = O(N)

Console.WriteLine("Expected = n. Actual = " + GetFirstNonDuplicate("minimum")); // should print n
Console.WriteLine("Expected = d. Actual = " + GetFirstNonDuplicate("aabbccdee")); // should print d