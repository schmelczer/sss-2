/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE426_Untrusted_Search_Path__Process_01.cs
Label Definition File: CWE426_Untrusted_Search_Path.label.xml
Template File: point-flaw-01.tmpl.cs
*/
/*
* @description
* CWE: 426 Untrusted Search Path
* Sinks: Process
*    GoodSink: Execute the command with full path
*    BadSink : Execute the command without full path
* Flow Variant: 01 Baseline
*
* */

using TestCaseSupport;
using System;

using System.Runtime.InteropServices;
using System.Diagnostics;

namespace testcases.CWE426_Untrusted_Search_Path
{
class CWE426_Untrusted_Search_Path__Process_01 : AbstractTestCase
{

#if (!OMITGOOD)
    public override void Good()
    {
        Good1();
    }

    private void Good1()
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
#endif //omitgood
}
}
