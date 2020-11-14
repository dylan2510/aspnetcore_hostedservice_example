using Microsoft.Extensions.Hosting;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace HostedServiceExample.Services
{
    public class HelloWorldHostedService : IHostedService
    {
        private Timer _timer;

        // run the logic on start
        public Task StartAsync(CancellationToken cancellationToken)
        {
            // Register the timer task that runs in the background
            RegisterTimerTask();
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Debug.WriteLine($"Stopping task..");
            return Task.CompletedTask;
        }

        private void RegisterTimerTask()
        {
            // Call helloworld every 5 seconds in background
            _timer = new Timer(HelloWorld, null, 0, 5000);
        }

        void HelloWorld(object state)
        {
            Debug.WriteLine($"{DateTime.Now}");
            Debug.WriteLine("Hello World !");
            Debug.WriteLine("This is a hosted service");
        }
    }
}
