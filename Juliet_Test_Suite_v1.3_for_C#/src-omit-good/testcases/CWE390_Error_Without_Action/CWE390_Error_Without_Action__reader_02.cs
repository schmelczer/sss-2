/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE390_Error_Without_Action__reader_02.cs
Label Definition File: CWE390_Error_Without_Action.label.xml
Template File: point-flaw-02.tmpl.cs
*/
/*
* @description
* CWE: 390 Detection of Error Condition Without Action
* Sinks: reader
*    GoodSink: Report and rethrow FileNotFoundException
*    BadSink : Catch FileNotFoundException, but don't do anything about it
* Flow Variant: 02 Control flow: if(true) and if(false)
*
* */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE390_Error_Without_Action
{
class CWE390_Error_Without_Action__reader_02 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (true)
        {
            int p = (int)Environment.OSVersion.Platform;
            string path = null;
            if (p == (int)PlatformID.Win32NT || p == (int)PlatformID.Win32Windows || p == (int)PlatformID.Win32S || p == (int)PlatformID.WinCE)
            {
                /* running on Windows */
                path = "C:\\doesntexistandneverwill.txt";
            }
            else
            {
                /* running on non-Windows */
                path = "/home/user/doesntexistandneverwill.txt";
            }
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    IO.WriteLine("Created a StreamReader");
                }
            }
            catch (FileNotFoundException exceptFileNotFound)
            {
                /* FLAW: do nothing if the file doesn't exist */
            }
        }
    }
#endif //omitbad

}
}
