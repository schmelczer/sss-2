/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE78_OS_Command_Injection__Environment_12.cs
Label Definition File: CWE78_OS_Command_Injection.label.xml
Template File: sources-sink-12.tmpl.cs
*/
/*
* @description
* CWE: 78 OS Command Injection
* BadSource: Environment Read data from an environment variable
* GoodSource: A hardcoded string
* BadSink: exec dynamic command execution with Runtime.getRuntime().exec()
* Flow Variant: 12 Control flow: if(IO.StaticReturnsTrueOrFalse())
*
* */

using TestCaseSupport;
using System;

using System.Diagnostics;
using System.Runtime.InteropServices;

using System.Web;

namespace testcases.CWE78_OS_Command_Injection
{

class CWE78_OS_Command_Injection__Environment_12 : AbstractTestCase
{
#if (!OMITBAD)
    /* uses badsource and badsink - see how tools report flaws that don't always occur */
    public override void Bad()
    {
        string data;
        if (IO.StaticReturnsTrueOrFalse())
        {
            /* get environment variable ADD */
            /* POTENTIAL FLAW: Read data from an environment variable */
            data = Environment.GetEnvironmentVariable("ADD");
        }
        else
        {
            /* FIX: Use a hardcoded string */
            data = "foo";
        }
        String osCommand;
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            /* running on Windows */
            osCommand = "c:\\WINDOWS\\SYSTEM32\\cmd.exe /c dir ";
        }
        else
        {
            /* running on non-Windows */
            osCommand = "/bin/ls ";
        }
        /* POTENTIAL FLAW: command injection */
        Process process = Process.Start(osCommand + data);
        process.WaitForExit();
    }
#endif //omitbad

}
}