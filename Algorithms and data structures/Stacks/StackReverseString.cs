//Function that uses a stack to reverse a string
//e.g. "abcde" becomes "edcba"
using System.Collections;

string ReverseString(string s)
{
    Stack stack = new Stack();
    foreach (char c in s)
    {
        stack.Push(c);
    }
    string reversedString = string.Empty;
    while (stack.Count > 0)
    {
        reversedString += stack.Pop();
    }
    return reversedString;
}

Console.WriteLine("expected = edcba, actual = " + ReverseString("abcde"));
Console.WriteLine("expected = 54321, actual = " + ReverseString("12345"));