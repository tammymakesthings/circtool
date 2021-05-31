using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using com.tammymakesthings.circtool.lib;

namespace com.tammymakesthings.circtool.handlers
{
    public class BaseCommandHandler
    {
        public bool VerboseMode { get; set; }
        public BaseCommandHandler(bool verboseMode)
        {
            this.VerboseMode = verboseMode;
        }

        public virtual void HandleCommand()
        {
            this.HandleCommand(Console.In, Console.Out, Console.Error);
        }

        public virtual void HandleCommand(TextReader stdin, TextWriter stdout, TextWriter stderr)
        {

        }
    }
}
