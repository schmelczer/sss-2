/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE113_HTTP_Response_Splitting__Web_Listen_tcp_addCookie_53c.cs
Label Definition File: CWE113_HTTP_Response_Splitting__Web.label.xml
Template File: sources-sinks-53c.tmpl.cs
*/
/*
 * @description
 * CWE: 113 HTTP Response Splitting
 * BadSource: Listen_tcp Read data using a listening tcp connection
 * GoodSource: A hardcoded string
 * Sinks: addCookie
 *    GoodSink: URLEncode input
 *    BadSink : querystring to AppendCookie()
 * Flow Variant: 53 Data flow: data passed as an argument from one method through two others to a fourth; all four functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;
using System.Text;

namespace testcases.CWE113_HTTP_Response_Splitting
{
class CWE113_HTTP_Response_Splitting__Web_Listen_tcp_addCookie_53c
{
#if (!OMITBAD)
    public static void BadSink(string data , HttpRequest req, HttpResponse resp)
    {
        CWE113_HTTP_Response_Splitting__Web_Listen_tcp_addCookie_53d.BadSink(data , req, resp);
    }
#endif


}
}