//Intersect (returns a third array with the common values in 2 arrays)

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
List<int> arr = intersection(arr1, arr2);
string output = "";

for (int i = 0; i < arr.Count; i++)
{
    output += arr[i];
}
Console.WriteLine(output);