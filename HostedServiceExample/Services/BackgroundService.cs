using Microsoft.Extensions.Hosting;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace HostedServiceExample.Services
{
    // Background Service implements IHostedService and IDisposable
    // Suitable for continuous running task 
    public class HelloWorldBackgroundService : BackgroundService
    {
        protected async override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                Debug.WriteLine("Background service running !! Hello !");
                await Task.Delay(8000, stoppingToken);
            }
        }
    }
}
