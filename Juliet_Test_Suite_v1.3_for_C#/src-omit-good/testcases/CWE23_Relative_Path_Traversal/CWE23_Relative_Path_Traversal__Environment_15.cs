/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE23_Relative_Path_Traversal__Environment_15.cs
Label Definition File: CWE23_Relative_Path_Traversal.label.xml
Template File: sources-sink-15.tmpl.cs
*/
/*
* @description
* CWE: 23 Relative Path Traversal
* BadSource: Environment Read data from an environment variable
* GoodSource: A hardcoded string
* BadSink: readFile no validation
* Flow Variant: 15 Control flow: switch(6)
*
* */

using TestCaseSupport;
using System;

using System.IO;

using System.Web;

namespace testcases.CWE23_Relative_Path_Traversal
{

class CWE23_Relative_Path_Traversal__Environment_15 : AbstractTestCase
{
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad()
    {
        string data = null;
        switch (6)
        {
        case 6:
            /* get environment variable ADD */
            /* POTENTIAL FLAW: Read data from an environment variable */
            data = Environment.GetEnvironmentVariable("ADD");
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
            break;
        }
        int p = (int)Environment.OSVersion.Platform;
        string root;
        if (p == (int)PlatformID.Win32NT || p == (int)PlatformID.Win32Windows || p == (int)PlatformID.Win32S || p == (int)PlatformID.WinCE)
        {
            /* running on Windows */
            root = "C:\\uploads\\";
        }
        else
        {
            /* running on non-Windows */
            root = "/home/user/uploads/";
        }
        if (data != null)
        {
            /* POTENTIAL FLAW: no validation of concatenated value */
            if (File.Exists(root + data))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(root + data))
                    {
                        IO.WriteLine(sr.ReadLine());
                    }
                }
                catch (IOException exceptIO)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
                }
            }
        }
    }
#endif //omitbad

}
}
