using Imagile.BlazorAppInsights.Models;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Imagile.BlazorAppInsights.Interfaces;

[EditorBrowsable(EditorBrowsableState.Never)]
[Browsable(false)]
public interface IPropertiesPlugin
{
    Task<TelemetryContext> Context();
}
