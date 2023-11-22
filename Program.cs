partial class Program
{
    static void Main(string[] args)
    {
        StopWatch watch = new StopWatch();
        watch.Start();
        Thread.Sleep(3000);
        watch.Stop();

        try
        {
            watch.Start();
            watch.Start();
            Thread.Sleep(5000);
            watch.Stop();
        }
        catch (System.Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
    }
}