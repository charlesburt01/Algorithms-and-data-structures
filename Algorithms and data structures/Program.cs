int CountXSimpler(string s)
{
    if (s.Length == 0) return 0;
    else if (s[0] == 'x') return 1 + CountXSimpler(s.Substring(1));
    else return CountXSimpler(s.Substring(1));
}

Console.WriteLine("Expected = 3, actual = " + CountXSimpler("axbxcxd"));
Console.WriteLine("Expected = 5, actual = " + CountXSimpler("axxbxcxdx"));