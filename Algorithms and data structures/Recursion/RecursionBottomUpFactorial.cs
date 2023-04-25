//bottom up recursive factorial (multiply all numbers up to a number, starting from 1)
int factorial(int n, int i = 1, int product = 1)
{
    Console.WriteLine($"n = {n}, i={i}, product={product}");
    if (i > n) return product;
    return factorial(n, i + 1, product * i);
}
Console.WriteLine(factorial(2));