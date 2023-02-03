namespace MultithreadingApp;

public class NetworkStatusChecker
{
    public void CheckNetworkStatus(object data)
    {
        for (int i = 0; i < 12; i++)
        {
            bool isNetwork = System.Net.NetworkInformation
            .NetworkInterface.GetIsNetworkAvailable();
            Console.WriteLine($"Is Network Available? Thread {(string) data}" +
                $" Answer: {isNetwork}");
            i++;
        }
    }

    public void CheckNetworkStatus2(object data)
    {
        bool finish = false;
        var canceltoken = (CancellationToken)data;
        canceltoken.Register(() => { finish = true; });
        while (!finish)
        {
            bool isNetwork = System.Net.NetworkInformation
            .NetworkInterface.GetIsNetworkAvailable();
            Console.WriteLine($"Is Network Available?" +
                $" Answer: {isNetwork}");
        }
    }
}