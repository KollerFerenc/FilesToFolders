using System;
using System.IO;
using Serilog;
using CommandDotNet;

namespace FilesToFolders
{
    class Program
    {
        internal static readonly string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;


        static void Main(string[] args)
        {
            ConfigureLogger();

            var appRunner = new AppRunner<FileSorter>()
                .UseDefaultMiddleware();
            appRunner.Run(args);

            Log.CloseAndFlush();
        }
        private static void ConfigureLogger()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File(Path.Join(baseDirectory, @"logs\log-.txt"),
                    rollingInterval: RollingInterval.Year,
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u4}] {Message:lj}{NewLine}{Exception}")
                .CreateLogger();
        }
    }
}
