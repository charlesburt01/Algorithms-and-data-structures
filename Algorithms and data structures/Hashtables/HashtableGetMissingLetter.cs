//a function that accepts a string that contains all the letters of the alphabet, except one and returns the missing letter.
//e.g. "the quick brown box jumps over the lazy dog" contains all the letters of the alphabet, except f because I changed fox to box.

//How would I go about writing this function?
//Well there will likely be duplicate letters, but one will be missing. We only care about the one that is missing. We know what letters are required, as we know the alphabet.
//my guess is that we use a hashtable hardcoded alphabet, setting all values to false, then true when found, the ones that remain as false will be the missing letters.

using System.Collections;

char GetMissingLetter(string inputString)
{
    Hashtable alphabetTable = new Hashtable();

    for (int i = 'a'; i <= 'z'; i++)//=======================26 steps
    {
        char key = (char)i;
        alphabetTable[key] = false;
    }

    foreach (char letter in inputString) //===================N steps
    {
        if (alphabetTable.ContainsKey(letter))
            alphabetTable[letter] = true;
    }

    for (int i = 'a'; i <= 'z'; i++) //========================26 steps
    {
        char key = (char)(i);
        if (alphabetTable[key] is false)
            return key;
    }
    return '0';
} //==========================================================TOTAL O(N+26+26) = O(N)
Console.WriteLine(GetMissingLetter("the quick brown box jumps over the lazy dog"));

//An alternative way is to store the input string in the hashtable, and then check all the letters of the alphabet against it, the one that doesn't appear gets returned
char? GetMissingLetterFaster(string inputString)
{
    Hashtable inputStringHash = new Hashtable();
    foreach (char letter in inputString)
    {
        inputStringHash[letter] = true;
    }
    string alphabet = "abcdefghijklmnopqurstuvxyz";
    foreach (char letter in alphabet)
    {
        if (inputStringHash.ContainsKey(letter) == false)
            return letter;
    }
    return null;
}
Console.WriteLine(GetMissingLetterFaster("the quick brown box jumps over the lazy dog"));