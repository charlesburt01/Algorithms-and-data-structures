

int steps = 0;
//Slow example of a function of N^2 as it uses nested loops, there is a better way to write this using python, and arrays that don't require you to set a size, whereas C# requires you to do this. Use a list I hear you say, well actually I'll need to insert a value into a cell at an index, List<int> doesn't allow you to do that. So moving on.
bool HasDuplicateValue(int[] array)
{
    steps = 0;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length; j++)
        {
            steps++;
            if(i != j && array[i] == array[j])
                return true;
        }
    }
    return false;
}
//Lets use an array with no duplicates so that we get the worst case scenario for the function
int[] arrayWithNoDuplicates = new int[] { 0, 6, 1, 2, 4 };
bool hasDuplicates = HasDuplicateValue(arrayWithNoDuplicates);
Console.WriteLine("Array size = " + arrayWithNoDuplicates.Length + ". Steps taken = " + steps + ". Has Duplicates = " + hasDuplicates);
