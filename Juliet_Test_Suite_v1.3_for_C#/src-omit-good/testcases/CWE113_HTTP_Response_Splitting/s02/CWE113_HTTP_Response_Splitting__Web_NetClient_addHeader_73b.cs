/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE113_HTTP_Response_Splitting__Web_NetClient_addHeader_73b.cs
Label Definition File: CWE113_HTTP_Response_Splitting__Web.label.xml
Template File: sources-sinks-73b.tmpl.cs
*/
/*
 * @description
 * CWE: 113 HTTP Response Splitting
 * BadSource: NetClient Read data from a web server with WebClient
 * GoodSource: A hardcoded string
 * Sinks: addHeader
 *    GoodSink: URLEncode input
 *    BadSink : querystring to AddHeader()
 * Flow Variant: 73 Data flow: data passed in a LinkedList from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;
using System.Collections.Generic;

using System.Web;
using System.Text;

namespace testcases.CWE113_HTTP_Response_Splitting
{
class CWE113_HTTP_Response_Splitting__Web_NetClient_addHeader_73b
{
#if (!OMITBAD)
    public static void BadSink(LinkedList<string> dataLinkedList , HttpRequest req, HttpResponse resp)
    {
        string data = dataLinkedList.Last.Value;
        /* POTENTIAL FLAW: Input from file not verified */
        if (data != null)
        {
            resp.AddHeader("Location", "/author.jsp?lang=" + data);
        }
    }
#endif


}
}
