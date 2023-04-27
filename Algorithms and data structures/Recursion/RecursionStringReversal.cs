//Recursive string reversal
using System;

string reverse(string forward)
{
    if (forward.Length == 1) return forward[0].ToString();
    string lastLetter = forward[forward.Length - 1].ToString();
    return lastLetter += reverse(forward.Substring(0, forward.Length - 1));
}
Console.WriteLine("Expected = cba, actual = " + reverse("abc"));
Console.WriteLine("Expected = gfedcba, actual = " + reverse("abcdefg"));



//Recursive string reversal simpler
string reverseSimpler(string forward)
{
    if (forward.Length == 1) return forward[0].ToString();
    return forward[forward.Length - 1].ToString() + reverseSimpler(forward.Substring(0, forward.Length - 1));
}
Console.WriteLine("Expected = cba, actual = " + reverseSimpler("abc"));
Console.WriteLine("Expected = gfedcba, actual = " + reverseSimpler("abcdefg"));


//Recursive string reversal even simpler
string reverseEvenSimpler(string forward)
{
    if (forward.Length == 1) return forward[0].ToString();
    return forward[^1].ToString() + reverseEvenSimpler(forward[..^1]);
}
Console.WriteLine("Expected = cba, actual = " + reverseEvenSimpler("abc"));
Console.WriteLine("Expected = gfedcba, actual = " + reverseEvenSimpler("abcdefg"));


//Recursive string reversal another version
string reverseAnotherVersion(string forward)
{
    if (forward.Length == 1) return forward[0].ToString();
    return reverseAnotherVersion(forward.Substring(1, forward.Length - 1)) + forward[0];
}
Console.WriteLine("Expected = cba, actual = " + reverseAnotherVersion("abc"));
Console.WriteLine("Expected = gfedcba, actual = " + reverseAnotherVersion("abcdefg"));