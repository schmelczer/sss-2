/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE426_Untrusted_Search_Path__Process_05.cs
Label Definition File: CWE426_Untrusted_Search_Path.label.xml
Template File: point-flaw-05.tmpl.cs
*/
/*
* @description
* CWE: 426 Untrusted Search Path
* Sinks: Process
*    GoodSink: Execute the command with full path
*    BadSink : Execute the command without full path
* Flow Variant: 05 Control flow: if(privateTrue) and if(privateFalse)
*
* */

using TestCaseSupport;
using System;

using System.Runtime.InteropServices;
using System.Diagnostics;

namespace testcases.CWE426_Untrusted_Search_Path
{
class CWE426_Untrusted_Search_Path__Process_05 : AbstractTestCase
{
    /* The two variables below are not defined as "readonly", but are never
     * assigned any other value, so a tool should be able to identify that
     * reads of these will always return their initialized values.
     */
    private bool privateTrue = true;
    private bool privateFalse = false;
#if (!OMITBAD)
    public override void Bad()
    {
        if (privateTrue)
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
        }
    }
#endif //omitbad
#if (!OMITGOOD)
    /* Good1() changes privateTrue to privateFalse */
    private void Good1()
    {
        if (privateFalse)
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
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

    /* Good2() reverses the bodies in the if statement */
    private void Good2()
    {
        if (privateTrue)
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
        Good2();
    }
#endif //omitgood
}
}
