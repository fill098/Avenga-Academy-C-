

Console.WriteLine("Tasks");

//Task myTask = new Task(() => { });

Task myTask = Task.Run(() =>
{
    Thread.Sleep(2000);
    Console.WriteLine("Running after 2000 ms.");
    
});

Console.WriteLine($"Right after start: {myTask.Status}");
Thread.Sleep(500);
Console.WriteLine($"While running: {myTask.Status}");
myTask.Wait();
Console.WriteLine($"After coomplitiation: {myTask.Status}");

// Task retutinig some value


Task<int> valueTask = Task.Run(() =>
{
    Thread.Sleep(1500);
    return 300;
});


Console.WriteLine(valueTask.Result);
Console.WriteLine($"Status after .Result: {valueTask.Status}");

Console.WriteLine("20 Task in paralel");

Random rnd = new Random();
for (int i = 1; i <= 20; i++)
{
    int temp = i;
    Task.Run(() =>
    {
        int dalay = rnd.Next(500, 2000);
        Thread.Sleep(dalay);
        Console.WriteLine($"Task {temp} done after {dalay} ms. Thread Id : {Thread.CurrentThread.ManagedThreadId}");
    });

}