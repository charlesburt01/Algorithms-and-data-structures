//Queues - a print job manager for a document printer

using System;
using System.Collections;

PrintManager printManager = new PrintManager();
printManager.QueuePrintJob("Doc 1"); // expected = Doc 1
printManager.QueuePrintJob("Doc 2"); // expected = Doc 2
printManager.QueuePrintJob("Doc 3"); // expected = Doc 3
printManager.Run();

class PrintManager
{
    Queue printQueue;
    public PrintManager()
    {
        printQueue = new Queue();
    }
    public void QueuePrintJob(string document)
    {
        printQueue.Enqueue(document);
    }
    public void Run()
    {
        while (printQueue.Count > 0)
        {
            Console.WriteLine(printQueue.Dequeue());
        }
    }
}

