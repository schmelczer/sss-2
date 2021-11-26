/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE601_Open_Redirect__Web_Listen_tcp_68a.cs
Label Definition File: CWE601_Open_Redirect__Web.label.xml
Template File: sources-sink-68a.tmpl.cs
*/
/*
 * @description
 * CWE: 601 Open Redirect
 * BadSource: Listen_tcp Read data using a listening tcp connection
 * GoodSource: A hardcoded string
 * BadSink:  place redirect string directly into redirect api call
 * Flow Variant: 68 Data flow: data passed as a member variable in the "a" class, which is used by a method in another class in the same package
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

class CWE601_Open_Redirect__Web_Listen_tcp_68a : AbstractTestCaseWeb
{

    public static string data;

#if (!OMITGOOD)
    public override void Good(HttpRequest req, HttpResponse resp)
    {
        GoodG2B(req, resp);
    }

    /* goodG2B() - use goodsource and badsink */
    private static void GoodG2B(HttpRequest req, HttpResponse resp)
    {
        /* FIX: Use a hardcoded string */
        data = "foo";
        CWE601_Open_Redirect__Web_Listen_tcp_68b.GoodG2BSink(req, resp);
    }
#endif //omitgood
}
}
