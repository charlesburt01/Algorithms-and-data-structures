//recursive summation of all numbers (inclusive) inbetween low and high bounds
int sum(int low, int high)
{
    if (high == low) return low;
    return high + sum(low, high - 1);
}
Console.WriteLine("Expected = 55, actual = " + sum(1, 10));