/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE426_Untrusted_Search_Path__Process_16.cs
Label Definition File: CWE426_Untrusted_Search_Path.label.xml
Template File: point-flaw-16.tmpl.cs
*/
/*
* @description
* CWE: 426 Untrusted Search Path
* Sinks: Process
*    GoodSink: Execute the command with full path
*    BadSink : Execute the command without full path
* Flow Variant: 16 Control flow: while(true)
*
* */

using TestCaseSupport;
using System;

using System.Runtime.InteropServices;
using System.Diagnostics;

namespace testcases.CWE426_Untrusted_Search_Path
{
class CWE426_Untrusted_Search_Path__Process_16 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        while(true)
        {
            /* FLAW: Execute command without the full path */
            string badOsCommand;
            string commandArgs;
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                badOsCommand = "ls";
                commandArgs = "-la";
            }
            else
            {
                badOsCommand = "cmd.exe";
                commandArgs = "/C dir";
            }
            using (Process process = new Process())
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = badOsCommand;
                startInfo.Arguments = commandArgs;
                process.StartInfo = startInfo;
                process.StartInfo.UseShellExecute = false;
                process.Start();
            }
            break;
        }
    }
#endif //omitbad

}
}
