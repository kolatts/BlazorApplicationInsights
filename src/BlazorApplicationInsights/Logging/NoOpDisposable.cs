﻿using System;

// ReSharper disable once CheckNamespace
namespace Imagile.BlazorAppInsights;

/// <summary>Dummy class used where we want a disposable instance that doesn't do anything</summary>
internal sealed class NoOpDisposable : IDisposable
{
    public static IDisposable Instance { get; } = new NoOpDisposable();
    private NoOpDisposable() { }
    public void Dispose() { }
}