/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE113_HTTP_Response_Splitting__Web_QueryString_Web_addCookie_54a.cs
Label Definition File: CWE113_HTTP_Response_Splitting__Web.label.xml
Template File: sources-sinks-54a.tmpl.cs
*/
/*
 * @description
 * CWE: 113 HTTP Response Splitting
 * BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
 * GoodSource: A hardcoded string
 * Sinks: addCookie
 *    GoodSink: URLEncode input
 *    BadSink : querystring to AppendCookie()
 * Flow Variant: 54 Data flow: data passed as an argument from one method through three others to a fifth; all five functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;
using System.Text;


namespace testcases.CWE113_HTTP_Response_Splitting
{
class CWE113_HTTP_Response_Splitting__Web_QueryString_Web_addCookie_54a : AbstractTestCaseWeb
{

#if (!OMITGOOD)
    public override void Good(HttpRequest req, HttpResponse resp)
    {
        GoodG2B(req, resp);
        GoodB2G(req, resp);
    }

    /* goodG2B() - use goodsource and badsink */
    private void GoodG2B(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* FIX: Use a hardcoded string */
        data = "foo";
        CWE113_HTTP_Response_Splitting__Web_QueryString_Web_addCookie_54b.GoodG2BSink(data , req, resp);
    }

    /* goodB2G() - use badsource and goodsink */
    private void GoodB2G(HttpRequest req, HttpResponse resp)
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
        CWE113_HTTP_Response_Splitting__Web_QueryString_Web_addCookie_54b.GoodB2GSink(data , req, resp);
    }
#endif //omitgood
}
}