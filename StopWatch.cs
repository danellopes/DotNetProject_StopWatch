partial class Program
{
    public class StopWatch
    {
        private bool IsRunning = false;
        private DateTime StartDateTime;
        public TimeSpan TimeSpan;

        public void Start()
        {
            if (this.IsRunning)
            {
                throw new InvalidOperationException("O contador está rodando e não pode ser iniciado novamente.");
            }

            this.StartDateTime = DateTime.Now;
            this.IsRunning = true;

            System.Console.WriteLine("Relógio iniciado: {0}", this.StartDateTime.ToString("dd/MM/yyyy HH:mm:ss"));
        }

        public void Stop()
        {
            this.TimeSpan = this.TimeSpan.Add(DateTime.Now - this.StartDateTime);
            this.IsRunning = false;

            System.Console.WriteLine("Relógio interrompido, tempo decorrido: {0:D2}:{1:D2}:{2:D2}", this.TimeSpan.Hours, this.TimeSpan.Minutes, this.TimeSpan.Seconds);
        }
    }
}