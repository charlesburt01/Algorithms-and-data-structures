//Tuples
Tuple<string, int>[] myTuple = new Tuple<string, int>[1]
{
    new Tuple<string, int>("u kidding maight?", 2)
};
Console.WriteLine(myTuple[0].Item1 + " " + myTuple[0].Item2);

Tuple<string, int, bool>[] myLargerTuple = new Tuple<string, int, bool>[1]
{
    new Tuple<string, int, bool>("u kidding maight?", 2, true)
};
Console.WriteLine(myLargerTuple[0].Item1 + " " + myLargerTuple[0].Item2 + " " + myLargerTuple[0].Item3);