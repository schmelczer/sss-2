/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE78_OS_Command_Injection__ReadLine_09.cs
Label Definition File: CWE78_OS_Command_Injection.label.xml
Template File: sources-sink-09.tmpl.cs
*/
/*
* @description
* CWE: 78 OS Command Injection
* BadSource: ReadLine Read data from the console using ReadLine()
* GoodSource: A hardcoded string
* BadSink: exec dynamic command execution with Runtime.getRuntime().exec()
* Flow Variant: 09 Control flow: if(IO.STATIC_READONLY_TRUE) and if(IO.STATIC_READONLY_FALSE)
*
* */

using TestCaseSupport;
using System;

using System.Diagnostics;
using System.Runtime.InteropServices;

using System.Web;

using System.IO;

namespace testcases.CWE78_OS_Command_Injection
{

class CWE78_OS_Command_Injection__ReadLine_09 : AbstractTestCase
{
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad()
    {
        string data;
        if (IO.STATIC_READONLY_TRUE)
        {
            data = ""; /* Initialize data */
            {
                /* read user input from console with ReadLine */
                try
                {
                    /* POTENTIAL FLAW: Read data from the console using ReadLine */
                    data = Console.ReadLine();
                }
                catch (IOException exceptIO)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
                }
            }
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
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
