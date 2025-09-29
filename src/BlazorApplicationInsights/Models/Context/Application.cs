﻿using System.Text.Json.Serialization;

namespace Imagile.BlazorAppInsights.Models.Context;

/// <summary>
/// Source: https://github.com/microsoft/ApplicationInsights-JS/blob/main/shared/AppInsightsCommon/src/Interfaces/Context/IApplication.ts
/// </summary>
public class Application
{
    /// <summary>
    /// The application version.
    /// </summary>
    [JsonPropertyName("ver")]
    public string Ver { get; set; }

    /// <summary>
    /// The application build version
    /// </summary>
    [JsonPropertyName("build")]
    public string Build { get; set; }
}