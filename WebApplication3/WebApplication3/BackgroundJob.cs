using Quartz;

namespace WebApplication3
{
    public class BackgroundJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            var i = 0;
            while (true)
            {
                Console.WriteLine("i:" + i.ToString());
                i++;
                Task.Delay(1000);
            }
        }
    }
}
