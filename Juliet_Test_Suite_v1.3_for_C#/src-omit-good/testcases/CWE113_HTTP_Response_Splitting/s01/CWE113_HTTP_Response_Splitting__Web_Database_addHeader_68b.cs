/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE113_HTTP_Response_Splitting__Web_Database_addHeader_68b.cs
Label Definition File: CWE113_HTTP_Response_Splitting__Web.label.xml
Template File: sources-sinks-68b.tmpl.cs
*/
/*
 * @description
 * CWE: 113 HTTP Response Splitting
 * BadSource: Database Read data from a database
 * GoodSource: A hardcoded string
 * Sinks: addHeader
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
class CWE113_HTTP_Response_Splitting__Web_Database_addHeader_68b
{
#if (!OMITBAD)
    public static void BadSink(HttpRequest req, HttpResponse resp)
    {
        string data = CWE113_HTTP_Response_Splitting__Web_Database_addHeader_68a.data;
        /* POTENTIAL FLAW: Input from file not verified */
        if (data != null)
        {
            resp.AddHeader("Location", "/author.jsp?lang=" + data);
        }
    }
#endif


}
}
