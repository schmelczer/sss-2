/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE113_HTTP_Response_Splitting__Web_QueryString_Web_addCookie_67b.cs
Label Definition File: CWE113_HTTP_Response_Splitting__Web.label.xml
Template File: sources-sinks-67b.tmpl.cs
*/
/*
 * @description
 * CWE: 113 HTTP Response Splitting
 * BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
 * GoodSource: A hardcoded string
 * Sinks: addCookie
 *    GoodSink: URLEncode input
 *    BadSink : querystring to AppendCookie()
 * Flow Variant: 67 Data flow: data passed in a class from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;
using System.Text;

namespace testcases.CWE113_HTTP_Response_Splitting
{
class CWE113_HTTP_Response_Splitting__Web_QueryString_Web_addCookie_67b
{
#if (!OMITBAD)
    public static void BadSink(CWE113_HTTP_Response_Splitting__Web_QueryString_Web_addCookie_67a.Container dataContainer , HttpRequest req, HttpResponse resp)
    {
        string data = dataContainer.containerOne;
        if (data != null)
        {
            HttpCookie cookieSink = new HttpCookie("lang", data);
            /* POTENTIAL FLAW: Input not verified before inclusion in the cookie */
            resp.AppendCookie(cookieSink);
        }
    }
#endif


}
}
