/*
 * Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000
For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

I can be placed before V (5) and X (10) to make 4 and 9. 
X can be placed before L (50) and C (100) to make 40 and 90. 
C can be placed before D (500) and M (1000) to make 400 and 900.
Given a roman numeral, convert it to an integer.

 

Example 1:

Input: s = "III"
Output: 3
Explanation: III = 3.
Example 2:

Input: s = "LVIII"
Output: 58
Explanation: L = 50, V= 5, III = 3.
Example 3:

Input: s = "MCMXCIV"
Output: 1994
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
 

Constraints:

1 <= s.length <= 15
s contains only the characters ('I', 'V', 'X', 'L', 'C', 'D', 'M').
It is guaranteed that s is a valid roman numeral in the range [1, 3999].
 * */
using System.Collections;
int RomanToInt(string s)
{
    int answer = 0;
    Hashtable letterValuePairs = new Hashtable()
        {
            { "I", 1 },
            { "V", 5 },
            { "X", 10 },
            { "L", 50 },
            { "C", 100 },
            { "D", 500 },
            { "M", 1000 }
        };
    for (int i = 0; i < s.Length; i++)
    {
        string pointer = s[i].ToString();
        string nextPointer = string.Empty;
        if (i != s.Length - 1)
            nextPointer = s[i + 1].ToString();
        Console.WriteLine($"pointer = {pointer} nextPointer = {nextPointer}");
        if (!letterValuePairs.ContainsKey(pointer)) continue;
        //catch the 6 cases where subtraction is used
        if (pointer == "I" && nextPointer == "V")
        {
            answer += 4;
            i++;
        }
        else if (pointer == "I" && nextPointer == "X")
        {
            answer += 9;
            i++;
        }
        else if (pointer == "X" && nextPointer == "L")
        {
            answer += 40;
            i++;
        }
        else if (pointer == "X" && nextPointer == "C")
        {
            answer += 90;
            i++;
        }
        else if (pointer == "C" && nextPointer == "D")
        {
            answer += 400;
            i++;
        }
        else if (pointer == "C" && nextPointer == "M")
        {
            answer += 900;
            i++;
        }
        //else calculate as normal
        else
            answer += (int)letterValuePairs[pointer];
    }
    return answer;
}
Console.WriteLine("expecting 3: " + RomanToInt("III"));
Console.WriteLine("expecting 58: " + RomanToInt("LVIII"));
Console.WriteLine("expecting 1994: " + RomanToInt("MCMXCIV"));