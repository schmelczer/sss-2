/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE113_HTTP_Response_Splitting__Web_File_setHeader_01.cs
Label Definition File: CWE113_HTTP_Response_Splitting__Web.label.xml
Template File: sources-sinks-01.tmpl.cs
*/
/*
* @description
* CWE: 113 HTTP Response Splitting
* BadSource: File Read data from file (named data.txt)
* GoodSource: A hardcoded string
* Sinks: setHeader
*    GoodSink: URLEncode input
*    BadSink : querystring to AddHeader()
* Flow Variant: 01 Baseline
*
* */

using TestCaseSupport;
using System;

using System.Web;
using System.Text;

using System.IO;

namespace testcases.CWE113_HTTP_Response_Splitting
{
class CWE113_HTTP_Response_Splitting__Web_File_setHeader_01 : AbstractTestCaseWeb
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
        if (data != null)
        {
            /* POTENTIAL FLAW: Input not verified before inclusion in header */
            resp.AddHeader("Location", "/author.jsp?lang=" + data);
        }
    }
#endif //omitbad

}
}
