﻿using Avalonia;
using Avalonia.Logging.Serilog;
using Avalonia.ReactiveUI;

namespace Camelotia.Presentation.Avalonia
{
    public sealed class Program
    {
        public static void Main(string[] args) => BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);

        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UseReactiveUI()
                .UsePlatformDetect()
                .LogToDebug();
    }
}
