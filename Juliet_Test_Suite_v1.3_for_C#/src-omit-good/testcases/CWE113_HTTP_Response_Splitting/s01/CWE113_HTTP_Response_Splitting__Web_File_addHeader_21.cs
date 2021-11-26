/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE113_HTTP_Response_Splitting__Web_File_addHeader_21.cs
Label Definition File: CWE113_HTTP_Response_Splitting__Web.label.xml
Template File: sources-sinks-21.tmpl.cs
*/
/*
 * @description
 * CWE: 113 HTTP Response Splitting
 * BadSource: File Read data from file (named data.txt)
 * GoodSource: A hardcoded string
 * Sinks: addHeader
 *    GoodSink: URLEncode input
 *    BadSink : querystring to AddHeader()
 * Flow Variant: 21 Control flow: Flow controlled by value of a private variable. All functions contained in one file.
 *
 * */

using TestCaseSupport;
using System;

using System.Web;
using System.Text;

using System.IO;

namespace testcases.CWE113_HTTP_Response_Splitting
{
class CWE113_HTTP_Response_Splitting__Web_File_addHeader_21 : AbstractTestCaseWeb
{

    /* The variable below is used to drive control flow in the sink function */
    private bool badPrivate = false;
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
        badPrivate = true;
        BadSink(data , req, resp);
    }

    private void BadSink(string data , HttpRequest req, HttpResponse resp)
    {
        if (badPrivate)
        {
            /* POTENTIAL FLAW: Input from file not verified */
            if (data != null)
            {
                resp.AddHeader("Location", "/author.jsp?lang=" + data);
            }
        }
    }
#endif //omitbad
    /* The variables below are used to drive control flow in the sink functions. */
    private bool goodB2G1Private = false;
    private bool goodB2G2Private = false;
    private bool goodG2BPrivate = false;

}
}
