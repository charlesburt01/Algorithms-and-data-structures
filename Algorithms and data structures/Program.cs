/*Use this file to run the code, copy paste the code from the other files
The property of the other .cs files are build action none, so they dont compile, they are just files to copy paste from into here
*/


//Recursive string reversal even simpler
string reverseEvenSimpler(string forward)
{
    if (forward.Length == 1) return forward[0].ToString();
    return reverseEvenSimpler(forward.Substring(1, forward.Length - 1)) + forward[0];
}
Console.WriteLine("Expected = cba, actual = " + reverseEvenSimpler("abc"));
Console.WriteLine("Expected = gfedcba, actual = " + reverseEvenSimpler("abcdefg"));