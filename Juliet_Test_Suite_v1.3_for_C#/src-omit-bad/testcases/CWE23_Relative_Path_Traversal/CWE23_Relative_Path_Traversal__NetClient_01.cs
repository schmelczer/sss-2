/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE23_Relative_Path_Traversal__NetClient_01.cs
Label Definition File: CWE23_Relative_Path_Traversal.label.xml
Template File: sources-sink-01.tmpl.cs
*/
/*
* @description
* CWE: 23 Relative Path Traversal
* BadSource: NetClient Read data from a web server with WebClient
* GoodSource: A hardcoded string
* BadSink: readFile no validation
* Flow Variant: 01 Baseline
*
* */

using TestCaseSupport;
using System;

using System.IO;

using System.Web;

using System.Net;

namespace testcases.CWE23_Relative_Path_Traversal
{

class CWE23_Relative_Path_Traversal__NetClient_01 : AbstractTestCase
{

#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
    }

    /* goodG2B() - uses goodsource and badsink */
    private void GoodG2B()
    {
        string data;
        /* FIX: Use a hardcoded string */
        data = "foo";
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
#endif //omitgood
}
}
