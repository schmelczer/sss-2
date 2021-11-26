/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE113_HTTP_Response_Splitting__Web_ReadLine_addCookie_03.cs
Label Definition File: CWE113_HTTP_Response_Splitting__Web.label.xml
Template File: sources-sinks-03.tmpl.cs
*/
/*
* @description
* CWE: 113 HTTP Response Splitting
* BadSource: ReadLine Read data from the console using ReadLine()
* GoodSource: A hardcoded string
* Sinks: addCookie
*    GoodSink: URLEncode input
*    BadSink : querystring to AppendCookie()
* Flow Variant: 03 Control flow: if(5==5) and if(5!=5)
*
* */

using TestCaseSupport;
using System;

using System.Web;
using System.Text;

using System.IO;

namespace testcases.CWE113_HTTP_Response_Splitting
{
class CWE113_HTTP_Response_Splitting__Web_ReadLine_addCookie_03 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        if (5==5)
        {
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
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        if (5==5)
        {
            if (data != null)
            {
                HttpCookie cookieSink = new HttpCookie("lang", data);
                /* POTENTIAL FLAW: Input not verified before inclusion in the cookie */
                resp.AppendCookie(cookieSink);
            }
        }
    }
#endif //omitbad

}
}
