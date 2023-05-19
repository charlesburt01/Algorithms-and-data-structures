
//Recursive counting X, counts the number of Xs in a given string
using System;

int CountX(string s, int x = 0)
{
    if (s.Length == 1)
    {
        if (s[0].ToString() == "x")
            return x + 1;
        else
            return x;
    }
    if (s[0].ToString() == "x")
        return CountX(s.Substring(1, s.Length - 1), x + 1);
    else
        return CountX(s.Substring(1, s.Length - 1), x);
}

Console.WriteLine("Expected = 3, actual = " + CountX("axbxcxd"));
Console.WriteLine("Expected = 5, actual = " + CountX("axxbxcxdx"));


int CountXSimple(string s)
{
    if (s.Length == 1)
    {
        if (s[0].ToString() == "x")
            return 1;
        else
            return 0;
    }
    if (s[0].ToString() == "x")
        return 1 + CountXSimple(s.Substring(1, s.Length - 1));
    else
        return CountXSimple(s.Substring(1, s.Length - 1));
}

Console.WriteLine("Expected = 3, actual = " + CountXSimple("axbxcxd"));
Console.WriteLine("Expected = 5, actual = " + CountXSimple("axxbxcxdx"));


int CountXSimpler(string s)
{
    if (s.Length == 0) return 0;
    else if (s[0] == 'x') return 1 + CountXSimpler(s.Substring(1));
    else return CountXSimpler(s.Substring(1));
}

Console.WriteLine("Expected = 3, actual = " + CountXSimpler("axbxcxd"));
Console.WriteLine("Expected = 5, actual = " + CountXSimpler("axxbxcxdx"));