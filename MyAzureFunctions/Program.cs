using Microsoft.Azure.WebJobs.Host;
using Microsoft.Azure.WebJobs.Script;
using System;


namespace MyAzureFunctions
{

    public static class Program
    {
        static void Main(string[] args)
        {
            var config = new ScriptHostConfiguration()
            {
               // RootLogPath = Environment.CurrentDirectory,
                RootScriptPath = "C:\\Users\\tsushi\\source\\repos\\MyAzureFunctions\\sample\\MyFunc",
                IsSelfHost = true,
                FileLoggingMode = FileLoggingMode.Always,
                RootLogPath = Environment.CurrentDirectory

            };
            var scriptHostManager = new ScriptHostManager(config);
            scriptHostManager.RunAndBlock();



        }
    }
}
