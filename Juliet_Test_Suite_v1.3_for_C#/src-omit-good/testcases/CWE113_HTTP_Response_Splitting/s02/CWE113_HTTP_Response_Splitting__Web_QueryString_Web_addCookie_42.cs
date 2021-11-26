/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE113_HTTP_Response_Splitting__Web_QueryString_Web_addCookie_42.cs
Label Definition File: CWE113_HTTP_Response_Splitting__Web.label.xml
Template File: sources-sinks-42.tmpl.cs
*/
/*
 * @description
 * CWE: 113 HTTP Response Splitting
 * BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
 * GoodSource: A hardcoded string
 * Sinks: addCookie
 *    GoodSink: URLEncode input
 *    BadSink : querystring to AppendCookie()
 * Flow Variant: 42 Data flow: data returned from one method to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Web;
using System.Text;


namespace testcases.CWE113_HTTP_Response_Splitting
{
class CWE113_HTTP_Response_Splitting__Web_QueryString_Web_addCookie_42 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    private static string BadSource(HttpRequest req, HttpResponse resp)
    {
        string data;
        data = ""; /* initialize data in case id is not in query string */
        /* POTENTIAL FLAW: Parse id param out of the URL querystring (without using getParameter()) */
        {
            if (req.QueryString["id"] != null)
            {
                data = req.QueryString["id"];
            }
        }
        return data;
    }

    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data = BadSource(req, resp);
        if (data != null)
        {
            HttpCookie cookieSink = new HttpCookie("lang", data);
            /* POTENTIAL FLAW: Input not verified before inclusion in the cookie */
            resp.AppendCookie(cookieSink);
        }
    }
#endif //omitbad

}
}
