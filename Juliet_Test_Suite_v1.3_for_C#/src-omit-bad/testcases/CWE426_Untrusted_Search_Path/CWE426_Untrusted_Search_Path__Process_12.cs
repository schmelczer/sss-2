/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE426_Untrusted_Search_Path__Process_12.cs
Label Definition File: CWE426_Untrusted_Search_Path.label.xml
Template File: point-flaw-12.tmpl.cs
*/
/*
* @description
* CWE: 426 Untrusted Search Path
* Sinks: Process
*    GoodSink: Execute the command with full path
*    BadSink : Execute the command without full path
* Flow Variant: 12 Control flow: if(IO.StaticReturnsTrueOrFalse())
*
* */

using TestCaseSupport;
using System;

using System.Runtime.InteropServices;
using System.Diagnostics;

namespace testcases.CWE426_Untrusted_Search_Path
{
class CWE426_Untrusted_Search_Path__Process_12 : AbstractTestCase
{

#if (!OMITGOOD)
    /* Good1() changes the "if" so that both branches use the GoodSink */
    private void Good1()
    {
        if (IO.StaticReturnsTrueOrFalse())
        {
            /* FIX: Execute command with the full path */
            string goodOsCommand;
            string commandArgs;
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                goodOsCommand = "/bin/ls";
                commandArgs = "-la";
            }
            else
            {
                goodOsCommand = "c:\\windows\\system32\\cmd.exe";
                commandArgs = "/C dir";
            }
            using (Process process = new Process())
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = goodOsCommand;
                startInfo.Arguments = commandArgs;
                process.StartInfo = startInfo;
                process.StartInfo.UseShellExecute = false;
                process.Start();
            }
        }
        else
        {
            /* FIX: Execute command with the full path */
            string goodOsCommand;
            string commandArgs;
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                goodOsCommand = "/bin/ls";
                commandArgs = "-la";
            }
            else
            {
                goodOsCommand = "c:\\windows\\system32\\cmd.exe";
                commandArgs = "/C dir";
            }
            using (Process process = new Process())
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = goodOsCommand;
                startInfo.Arguments = commandArgs;
                process.StartInfo = startInfo;
                process.StartInfo.UseShellExecute = false;
                process.Start();
            }
        }
    }

    public override void Good()
    {
        Good1();
    }
#endif //omitgood
}
}
