/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE78_OS_Command_Injection__NetClient_06.cs
Label Definition File: CWE78_OS_Command_Injection.label.xml
Template File: sources-sink-06.tmpl.cs
*/
/*
* @description
* CWE: 78 OS Command Injection
* BadSource: NetClient Read data from a web server with WebClient
* GoodSource: A hardcoded string
* BadSink: exec dynamic command execution with Runtime.getRuntime().exec()
* Flow Variant: 06 Control flow: if(PRIVATE_CONST_FIVE==5) and if(PRIVATE_CONST_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

using System.Diagnostics;
using System.Runtime.InteropServices;

using System.Web;

using System.IO;
using System.Net;

namespace testcases.CWE78_OS_Command_Injection
{

class CWE78_OS_Command_Injection__NetClient_06 : AbstractTestCase
{

    /* The variable below is declared "const", so a tool should be able
     * to identify that reads of this will always give its initialized
     * value.
     */
    private const int PRIVATE_CONST_FIVE = 5;

#if (!OMITGOOD)
    /* goodG2B1() - use goodsource and badsink by changing PRIVATE_CONST_FIVE==5 to PRIVATE_CONST_FIVE!=5 */
    private void GoodG2B1()
    {
        string data;
        if (PRIVATE_CONST_FIVE != 5)
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
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

    /* GoodG2B2() - use goodsource and badsink by reversing statements in if */
    private void GoodG2B2()
    {
        string data;
        if (PRIVATE_CONST_FIVE == 5)
        {
            /* FIX: Use a hardcoded string */
            data = "foo";
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

    public override void Good()
    {
        GoodG2B1();
        GoodG2B2();
    }
#endif //omitgood
}
}