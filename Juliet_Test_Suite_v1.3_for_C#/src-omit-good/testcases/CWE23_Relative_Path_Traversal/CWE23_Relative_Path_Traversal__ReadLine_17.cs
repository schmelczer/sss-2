/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE23_Relative_Path_Traversal__ReadLine_17.cs
Label Definition File: CWE23_Relative_Path_Traversal.label.xml
Template File: sources-sink-17.tmpl.cs
*/
/*
* @description
* CWE: 23 Relative Path Traversal
* BadSource: ReadLine Read data from the console using ReadLine()
* GoodSource: A hardcoded string
* BadSink: readFile no validation
* Flow Variant: 17 Control flow: for loops
*
* */

using TestCaseSupport;
using System;

using System.IO;

using System.Web;


namespace testcases.CWE23_Relative_Path_Traversal
{

class CWE23_Relative_Path_Traversal__ReadLine_17 : AbstractTestCase
{
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad()
    {
        string data;
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
        for (int i = 0; i < 1; i++)
        {
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
    }
#endif //omitbad

}
}