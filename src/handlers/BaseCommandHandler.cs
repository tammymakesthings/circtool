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
        public System.Text.StringBuilder Output { get; set; }

        public void AddOutput(string theOutput)
        {
            this.Output.AppendLine(theOutput);
        }

        public string GetOutput()
        {
            return this.Output.ToString();
        }
        public BaseCommandHandler(bool verboseMode)
        {
            this.Output = new System.Text.StringBuilder();
            this.VerboseMode = verboseMode;
        }

        public virtual string HandleCommand()
        {
            this.AddOutput("BaseCommandHandler");
            return this.GetOutput();
        }
    }
}
