/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE113_HTTP_Response_Splitting__Web_QueryString_Web_setHeader_68b.cs
Label Definition File: CWE113_HTTP_Response_Splitting__Web.label.xml
Template File: sources-sinks-68b.tmpl.cs
*/
/*
 * @description
 * CWE: 113 HTTP Response Splitting
 * BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
 * GoodSource: A hardcoded string
 * Sinks: setHeader
 *    GoodSink: URLEncode input
 *    BadSink : querystring to AddHeader()
 * Flow Variant: 68 Data flow: data passed as a member variable in the "a" class, which is used by a method in another class in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;
using System.Text;

namespace testcases.CWE113_HTTP_Response_Splitting
{
class CWE113_HTTP_Response_Splitting__Web_QueryString_Web_setHeader_68b
{
#if (!OMITBAD)
    public static void BadSink(HttpRequest req, HttpResponse resp)
    {
        string data = CWE113_HTTP_Response_Splitting__Web_QueryString_Web_setHeader_68a.data;
        if (data != null)
        {
            /* POTENTIAL FLAW: Input not verified before inclusion in header */
            resp.AddHeader("Location", "/author.jsp?lang=" + data);
        }
    }
#endif


}
}
