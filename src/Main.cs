using System;
using System.Threading.Tasks;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using com.tammymakesthings.circtool.lib;
using com.tammymakesthings.circtool.handlers;

namespace com.tammymakesthings.circtool
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var rootCommand = new RootCommand
            {
                new Option<bool>("--verbose", "Enable more verbose output")
            };

            var versionCommand = new Command("version");
            versionCommand.Description = "Display circtool version";
            versionCommand.Handler = CommandHandler.Create<bool>(DoVersionCommand);
            rootCommand.AddCommand(versionCommand);

            await rootCommand.InvokeAsync(args);
        }

        public static void DoVersionCommand(bool verboseMode)
        {
            new VersionHandler(verboseMode).HandleCommand();
        }
    }
}
