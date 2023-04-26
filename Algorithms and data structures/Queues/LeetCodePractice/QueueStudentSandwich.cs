//if student at the front of the queue prefers the sandwich at the top of the queue, they will take it and leave the queue
//if the don't prefer the sandwich, they will return to the back of the queue
//this continues until none of the queue students want to take the top sandwich and are unable to eat

int CountStudents(int[] students, int[] sandwiches)
{
    Queue<int> studentQueue = new Queue<int>(students);
    Queue<int> sandwichStack = new Queue<int>(sandwiches);

    int notEaten = 0;
    while (notEaten < studentQueue.Count)
    {
        Console.WriteLine($"notEaten = {notEaten}, studenQueue.Count = {studentQueue.Count}");
        if (studentQueue.Peek() == sandwichStack.Peek())
        {
            Console.WriteLine("Student liked and took sandwich");
            studentQueue.Dequeue();
            sandwichStack.Dequeue();
            notEaten = 0;
        }
        else
        {
            Console.WriteLine("Student didn't like sandwich");
            notEaten++;
            studentQueue.Enqueue(studentQueue.Peek());
            studentQueue.Dequeue();
        }
    }
    return notEaten;
}
Console.WriteLine("//////Expected = 0, actual = " + CountStudents(new int[] { 1, 1, 0, 0 }, new int[] { 0, 1, 0, 1 }));
Console.WriteLine("//////Expected = 3, actual = " + CountStudents(new int[] { 1, 1, 1, 0, 0, 1 }, new int[] { 1, 0, 0, 0, 1, 1 }));