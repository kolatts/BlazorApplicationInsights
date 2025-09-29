using Imagile.BlazorAppInsights.Interfaces;
using Imagile.BlazorAppInsights.Models;
using System;
using System.Threading.Tasks;

namespace Imagile.BlazorAppInsights
{
    internal class ApplicationInsightsInitConfig
    {
        public Config? Config { get; set; }

        public Func<IApplicationInsights, Task>? OnAppInsightsInit { get; set; }
    }
}
