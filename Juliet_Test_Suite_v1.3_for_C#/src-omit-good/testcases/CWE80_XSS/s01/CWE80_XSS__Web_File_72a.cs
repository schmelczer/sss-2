/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE80_XSS__Web_File_72a.cs
Label Definition File: CWE80_XSS__Web.label.xml
Template File: sources-sink-72a.tmpl.cs
*/
/*
 * @description
 * CWE: 80 Cross Site Scripting (XSS)
 * BadSource: File Read data from file (named data.txt)
 * GoodSource: A hardcoded string
 * Sinks: Web
 *    BadSink : Display of data in web page without any encoding or validation
 * Flow Variant: 72 Data flow: data passed in a Hashtable from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections;
using System;

using System.Web;

using System.IO;

namespace testcases.CWE80_XSS
{
class CWE80_XSS__Web_File_72a : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        data = ""; /* Initialize data */
        {
            try
            {
                /* read string from file into data */
                using (StreamReader sr = new StreamReader("data.txt"))
                {
                    /* POTENTIAL FLAW: Read data from a file */
                    /* This will be reading the first "line" of the file, which
                     * could be very long if there are little or no newlines in the file */
                    data = sr.ReadLine();
                }
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
            }
        }
        Hashtable dataHashtable = new Hashtable(5);
        dataHashtable.Add(0, data);
        dataHashtable.Add(1, data);
        dataHashtable.Add(2, data);
        CWE80_XSS__Web_File_72b.BadSink(dataHashtable , req, resp );
    }
#endif //omitbad

}
}
