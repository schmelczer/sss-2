/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE113_HTTP_Response_Splitting__Web_File_addCookie_53b.cs
Label Definition File: CWE113_HTTP_Response_Splitting__Web.label.xml
Template File: sources-sinks-53b.tmpl.cs
*/
/*
 * @description
 * CWE: 113 HTTP Response Splitting
 * BadSource: File Read data from file (named data.txt)
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
class CWE113_HTTP_Response_Splitting__Web_File_addCookie_53b
{
#if (!OMITBAD)
    public static void BadSink(string data , HttpRequest req, HttpResponse resp)
    {
        CWE113_HTTP_Response_Splitting__Web_File_addCookie_53c.BadSink(data , req, resp);
    }
#endif


}
}
