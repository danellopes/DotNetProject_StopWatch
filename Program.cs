partial class Program
{
    static void Main(string[] args)
    {
        StopWatch watch = new StopWatch();
        watch.Start();
        Thread.Sleep(3000);
        watch.Stop();

        watch.Start();
        Thread.Sleep(5000);
        watch.Stop();
    }
}