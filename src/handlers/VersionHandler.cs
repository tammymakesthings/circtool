using System;
using System.CommandLine;
using System.CommandLine.Invocation;
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

        public override void HandleCommand(TextReader stdin, TextWriter stdout, TextWriter stderr)
        {
            stdout.WriteLine(String.Format(
                "circtool v{0} - Tammy Cravit - <tammymakesthings@gmail.com> - {1}",
                com.tammymakesthings.circtool.lib.Version.APP_VERSION,
                com.tammymakesthings.circtool.lib.Version.APP_DATE.ToShortDateString())
            );
        }
    }
}
