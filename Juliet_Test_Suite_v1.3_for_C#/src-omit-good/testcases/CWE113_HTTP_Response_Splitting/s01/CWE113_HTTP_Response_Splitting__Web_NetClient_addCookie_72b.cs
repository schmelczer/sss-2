/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE113_HTTP_Response_Splitting__Web_NetClient_addCookie_72b.cs
Label Definition File: CWE113_HTTP_Response_Splitting__Web.label.xml
Template File: sources-sinks-72b.tmpl.cs
*/
/*
 * @description
 * CWE: 113 HTTP Response Splitting
 * BadSource: NetClient Read data from a web server with WebClient
 * GoodSource: A hardcoded string
 * Sinks: addCookie
 *    GoodSink: URLEncode input
 *    BadSink : querystring to AppendCookie()
 * Flow Variant: 72 Data flow: data passed in a Hashtable from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;
using System.Collections;

using System.Web;
using System.Text;

namespace testcases.CWE113_HTTP_Response_Splitting
{
class CWE113_HTTP_Response_Splitting__Web_NetClient_addCookie_72b
{
#if (!OMITBAD)
    public static void BadSink(Hashtable dataHashtable , HttpRequest req, HttpResponse resp)
    {
        string data = (string) dataHashtable[2];
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
