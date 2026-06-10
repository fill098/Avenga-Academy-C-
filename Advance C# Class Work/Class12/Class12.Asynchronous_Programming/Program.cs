


Console.WriteLine($"Main Thred Id: {Thread.CurrentThread.ManagedThreadId}");

// Synchronus

void SendMessages()
{
    Console.WriteLine("Getting Ready...");
    Thread.Sleep(2000);

    Console.WriteLine("First message arrived!");
    Thread.Sleep(2000);

    Console.WriteLine("Second message arrived!");
    Thread.Sleep(2000);

    Console.WriteLine("Third message arrived!");
    Console.WriteLine("All messages are received!");

    Console.ReadLine();
}

//SendMessages();


//  Asynchrouns

void SendMessagesThreads()
{
    Console.WriteLine("Getting Ready...");
    Random rnd = new Random();

    Thread t1 = new Thread(() =>
    {
        int delay = rnd.Next(500, 2000);
        Thread.Sleep(delay);
        Console.WriteLine($"First message arivied after {delay} ms! ThreadId: {Thread.CurrentThread.ManagedThreadId}");


    });

    Thread t2 = new Thread(() =>
    {
        int delay = rnd.Next(500, 2000);
        Thread.Sleep(delay);
        Console.WriteLine($"Second message arivied after {delay} ms! ThreadId: {Thread.CurrentThread.ManagedThreadId}");


    });

    Thread t3 = new Thread(() =>
    {
        int delay = rnd.Next(500, 2000);
        Thread.Sleep(delay);
        Console.WriteLine($"Third message arivied after {delay} ms! ThreadId: {Thread.CurrentThread.ManagedThreadId}");


    })
    { Name = "Our Thread 3 "};

    t1.Start();
    t2.Start();
    t3.Start();
    Console.WriteLine($"Main Thred Id: {Thread.CurrentThread.ManagedThreadId}");
}

SendMessagesThreads();