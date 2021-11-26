/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE113_HTTP_Response_Splitting__Web_QueryString_Web_addCookie_02.cs
Label Definition File: CWE113_HTTP_Response_Splitting__Web.label.xml
Template File: sources-sinks-02.tmpl.cs
*/
/*
* @description
* CWE: 113 HTTP Response Splitting
* BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
* GoodSource: A hardcoded string
* Sinks: addCookie
*    GoodSink: URLEncode input
*    BadSink : querystring to AppendCookie()
* Flow Variant: 02 Control flow: if(true) and if(false)
*
* */

using TestCaseSupport;
using System;

using System.Web;
using System.Text;


namespace testcases.CWE113_HTTP_Response_Splitting
{
class CWE113_HTTP_Response_Splitting__Web_QueryString_Web_addCookie_02 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        if (true)
        {
            data = ""; /* initialize data in case id is not in query string */
            /* POTENTIAL FLAW: Parse id param out of the URL querystring (without using getParameter()) */
            {
                if (req.QueryString["id"] != null)
                {
                    data = req.QueryString["id"];
                }
            }
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        if (true)
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
