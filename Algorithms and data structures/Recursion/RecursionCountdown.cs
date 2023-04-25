//Recursion
//Old method
void Countdown(int time)
{
    for (int i = time; i >= 0; i--)
    {
        Console.WriteLine(i);
    }
}
//Countdown(10);

//Recursive method
void CountdownRecursive(int number)
{
    Console.WriteLine(number);
    if (number == 0) return;
    CountdownRecursive(number -= 1);
}
CountdownRecursive(10);