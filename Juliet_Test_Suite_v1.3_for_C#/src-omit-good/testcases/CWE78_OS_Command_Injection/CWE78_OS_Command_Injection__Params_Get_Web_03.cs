/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE78_OS_Command_Injection__Params_Get_Web_03.cs
Label Definition File: CWE78_OS_Command_Injection.label.xml
Template File: sources-sink-03.tmpl.cs
*/
/*
* @description
* CWE: 78 OS Command Injection
* BadSource: Params_Get_Web Read data from a querystring using Params.Get()
* GoodSource: A hardcoded string
* BadSink: exec dynamic command execution with Runtime.getRuntime().exec()
* Flow Variant: 03 Control flow: if(5==5) and if(5!=5)
*
* */

using TestCaseSupport;
using System;

using System.Diagnostics;
using System.Runtime.InteropServices;

using System.Web;


namespace testcases.CWE78_OS_Command_Injection
{

class CWE78_OS_Command_Injection__Params_Get_Web_03 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        if (5 == 5)
        {
            /* POTENTIAL FLAW: Read data from a querystring using Params.Get */
            data = req.Params.Get("name");
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
