using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.Globalization;
using System.IO;
using System.Reflection;
using com.tammymakesthings.circtool.lib;

namespace com.tammymakesthings.circtool.handlers
{
    public class VersionHandler : BaseCommandHandler
    {
        public VersionHandler(bool verboseMode) : base(verboseMode)
        {
        }

        public override string HandleCommand()
        {
            this.AddOutput(String.Format("circtool {0} - {1}",
                com.tammymakesthings.circtool.lib.Version.APP_VERSION,
                com.tammymakesthings.circtool.lib.Version.APP_DATE.ToShortDateString()
                ));
            this.AddOutput("Tammy Cravit <tammymakesthings@gmail.com>");
            this.AddOutput("See https://github.com/tammymakesthings/circup/ for the latest version");
            return this.GetOutput();
        }
    }
}
