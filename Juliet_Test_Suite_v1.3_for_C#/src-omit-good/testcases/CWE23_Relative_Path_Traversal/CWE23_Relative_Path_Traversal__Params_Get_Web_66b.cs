/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE23_Relative_Path_Traversal__Params_Get_Web_66b.cs
Label Definition File: CWE23_Relative_Path_Traversal.label.xml
Template File: sources-sink-66b.tmpl.cs
*/
/*
 * @description
 * CWE: 23 Relative Path Traversal
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded string
 * Sinks: readFile
 *    BadSink : no validation
 * Flow Variant: 66 Data flow: data passed in an array from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.IO;

using System.Web;

namespace testcases.CWE23_Relative_Path_Traversal
{
class CWE23_Relative_Path_Traversal__Params_Get_Web_66b
{
#if (!OMITBAD)
    public static void BadSink(string[] dataArray , HttpRequest req, HttpResponse resp)
    {
        string data = dataArray[2];
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
#endif


}
}