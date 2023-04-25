//Recursion
//write a recursive function that prints all the numbers (and just numbers)
object[] array = new object[]
{
    1,
    2,
    3,
    new object[]{4,5,6 },
    7,
    new object[]{8,
        new object[]{9,10,11,
            new object[]{12,13,14}
        }
    },
    new object[]{15,16,17,18,19,
        new object[]{20,21,22,
            new object[] {23,24,25,
                new object[] {26,27,29},
                31,31,
            }, 32
        }, 33
    }
};
//using 1 foreach loop, but otherwise recursive
void printAllNumbers(object[] array)
{
    foreach (var item in array)
    {
        if (item.GetType() == typeof(int))
            Console.WriteLine(item);
        else if (item.GetType() == typeof(object[]))
            printAllNumbers((object[])item);
    }
}
printAllNumbers(array);