/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE81_XSS_Error_Message__Web_Connect_tcp_61b.cs
Label Definition File: CWE81_XSS_Error_Message__Web.label.xml
Template File: sources-sink-61b.tmpl.cs
*/
/*
 * @description
 * CWE: 81 Cross Site Scripting (XSS) in Error Message
 * BadSource: Connect_tcp Read data using an outbound tcp connection
 * GoodSource: A hardcoded string
 * Sinks: ErrorStatusCode
 *    BadSink : XSS in StatusCode
 * Flow Variant: 61 Data flow: data returned from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;
using System.Net.Sockets;

namespace testcases.CWE81_XSS_Error_Message
{

class CWE81_XSS_Error_Message__Web_Connect_tcp_61b
{


#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static string GoodG2BSource(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* FIX: Use a hardcoded string */
        data = "foo";
        return data;
    }
#endif
}
}
