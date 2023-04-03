/*Use this file to run the code, copy paste the code from the other files
The property of the other .cs files are build action none, so they dont compile, they are just files to copy paste from into here

Complexity cheat sheet in Big O notation, from fastest to worst

============== O(1) ...........Excellent (1st Place)
public static int Multiply(int a, int b)
{
    return a * b;
}
============== O(log n) ...........Excellent (2nd Place)
for(int i = 1; i <= n; i = i * 2)
{
    Console.WriteLine("Hello");
}
============== O(n) ...........Good (3rd Place) linear
for(int i = 1; i <= n; i++)
{
    Console.WriteLine("Hello");
}

============== O(n log n) ...........Bad (4th Place)
for(int i = 0; i < n; i++)
{
    for(int j = 1; j < n; j = j * 2)
    {
        Console.WriteLine("Hello");
    }
}
============== O(n^2) ........... Horrible (5th Place)
for(int i = 0; i < n; i++)
{
    for(int j = 0; j < n; j = j + 2)
    {
        Console.WriteLine("Hello");
    }
}
============== O(2^n) ........... Horrible (6th Place)
int fibonacci(int number)
{
    if(number <= 1) return number;

    return fibonacci(number - 2) + fibonacci(number - 1);
}
============== O(n!) ........... Horrible (7th Place)
no example yet

*/




//Insertion Sort

List<int> intersection(int[] firstArray, int[] secondArray)
{
    List<int> arr = new List<int>();

    for (int i = 0; i < firstArray.Length; i++)
    {
        for (int j = 0; j < secondArray.Length; j++)
        {
            if (firstArray[i] == secondArray[j])
            {
                arr.Add(firstArray[i]);
                break;
            }
        }
    }

    return arr;
}

int[] arr1 = new int[] { 4, 2, 7, 1, 3 };// 2, 4, 7, 1, 3 // 2, 4, 1, 7, 3 // 2, 1, 4, 7, 3 /// 1, 2, 4, 7, 3 /// 1, 2, 4, 3, 7 ///  1, 2, 4, 3, 7///  1, 2, 3, 4, 7
int[] arr2 = new int[] { 1, 2, 3, 3, 0 };// 2, 4, 7, 1, 3 // 2, 4, 1, 7, 3 // 2, 1, 4, 7, 3 /// 1, 2, 4, 7, 3 /// 1, 2, 4, 3, 7 ///  1, 2, 4, 3, 7///  1, 2, 3, 4, 7
List<int> arr = intersection(arr1,arr2);
string output = "";

for (int i = 0; i < arr.Count; i++)
{
    output += arr[i];
}
Console.WriteLine(output);