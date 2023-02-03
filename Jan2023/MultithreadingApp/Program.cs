using System.Diagnostics.Metrics;

namespace MultithreadingApp;

public class Program
{
    public static void Main()
    {
        //Console.WriteLine("Hello World");
        //var bgThread = new Thread((object? data) =>
        //{
        //    if (data is null) return;
        //    int counter = 0;
        //    var result = int.TryParse(data.ToString(), out int maxCount);
        //    if(!result) return;
        //    while (counter < maxCount)
        //    {
        //        bool isNetwork = System.Net.NetworkInformation
        //        .NetworkInterface.GetIsNetworkAvailable();
        //        Console.WriteLine($"Is Network Available? Answer: {isNetwork}");
        //        Thread.Sleep(100);
        //        counter++;
        //    }
        //});
        //bgThread.IsBackground = true;
        //bgThread.Start(12);
        //for(int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine($"Main Thread is running {i}");
        //    Thread.Sleep(100);
        //}
        //Console.WriteLine("Done");
        //Console.ReadKey();
        var network = new NetworkStatusChecker();
        var bgThread1 = new Thread(network.CheckNetworkStatus);
        var bgThread2 = new Thread(network.CheckNetworkStatus);
        var bgThread3 = new Thread(network.CheckNetworkStatus);
        var bgThread4 = new Thread(network.CheckNetworkStatus);
        var bgThread5 = new Thread(network.CheckNetworkStatus);
        bgThread1.Priority = ThreadPriority.Lowest;
        bgThread2.Priority = ThreadPriority.BelowNormal;
        bgThread3.Priority = ThreadPriority.Normal;
        bgThread4.Priority = ThreadPriority.AboveNormal;
        bgThread5.Priority = ThreadPriority.Highest;

        bgThread1.Start("Lowest");
        bgThread2.Start("BelowL");
        bgThread3.Start("Norm");
        bgThread4.Start("AbNorm");
        bgThread5.Start("High");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Main Thread is running {i}");
        }
        Console.WriteLine("Done");
        Console.ReadKey();
    }

    //ThreadState Enum Values:
    /*
     Aborted
     AbortRequested
    Background
    Running
     Stopped
     StopRequested
    Suspended
    SuspendRequested
    Unstarted
    WaitSleepJoin: The thread is currently block
     */
}
