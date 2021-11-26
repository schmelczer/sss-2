/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE601_Open_Redirect__Web_Listen_tcp_53a.cs
Label Definition File: CWE601_Open_Redirect__Web.label.xml
Template File: sources-sink-53a.tmpl.cs
*/
/*
 * @description
 * CWE: 601 Open Redirect
 * BadSource: Listen_tcp Read data using a listening tcp connection
 * GoodSource: A hardcoded string
 * Sinks:
 *    BadSink : place redirect string directly into redirect api call
 * Flow Variant: 53 Data flow: data passed as an argument from one method through two others to a fourth; all four functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;
using System.Net.Sockets;
using System.Net;

namespace testcases.CWE601_Open_Redirect
{

class CWE601_Open_Redirect__Web_Listen_tcp_53a : AbstractTestCaseWeb
{

#if (!OMITGOOD)
    public override void Good(HttpRequest req, HttpResponse resp)
    {
        GoodG2B(req, resp);
    }

    /* goodG2B() - use goodsource and badsink */
    private void GoodG2B(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* FIX: Use a hardcoded string */
        data = "foo";
        CWE601_Open_Redirect__Web_Listen_tcp_53b.GoodG2BSink(data , req, resp);
    }
#endif //omitgood
}
}
