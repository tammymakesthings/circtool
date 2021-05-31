using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using com.tammymakesthings.circtool.lib;

namespace com.tammymakesthings.circtool.lib
{
    public class Version
    {
        public static System.Version APP_VERSION
        {
            get { return (new System.Version(1, 0, 0)); }
        }

        public static System.DateTime APP_DATE
        {
            get { return new System.DateTime(2021, 05, 31); }
        }
    }
}
