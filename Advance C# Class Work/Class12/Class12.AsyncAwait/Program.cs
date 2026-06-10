using System.Diagnostics;

void SendMesssage(string message)
{
    Console.WriteLine("Sending message...");
    Thread.Sleep(3000);
    Console.WriteLine($"Message {message} sent!");

}
async Task SendMessageAsync(string message)
{
    Console.WriteLine("Sending message...");
    await Task.Delay(3000);
    Console.WriteLine($"Message {message} sent!");

}

void ShowAd()
{
    Console.WriteLine($"While you wait, here is and add. Buy the nw 'Iphone 17' for special price.");
}

Stopwatch stopwatch = new Stopwatch();
stopwatch.Restart();

SendMesssage("Hello from Avenga Academy!");
ShowAd();
stopwatch.Stop();
Console.WriteLine($"Total time {stopwatch.ElapsedMilliseconds} ms!!");


stopwatch.Restart();
SendMessageAsync("Hello from Avenga Academy!");
ShowAd();
stopwatch.Stop();
Console.WriteLine($"Total time {stopwatch.ElapsedMilliseconds} ms!!");



stopwatch.Restart();
await SendMessageAsync("Hello from Avenga Academy!");
ShowAd();
stopwatch.Stop();
Console.WriteLine($"Total time {stopwatch.ElapsedMilliseconds} ms!!");



