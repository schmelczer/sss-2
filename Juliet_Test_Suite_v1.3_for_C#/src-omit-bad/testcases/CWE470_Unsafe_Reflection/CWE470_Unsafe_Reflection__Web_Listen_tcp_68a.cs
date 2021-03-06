/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE470_Unsafe_Reflection__Web_Listen_tcp_68a.cs
Label Definition File: CWE470_Unsafe_Reflection__Web.label.xml
Template File: sources-sink-68a.tmpl.cs
*/
/*
 * @description
 * CWE: 470 Use of Externally-Controlled Input to Select Classes or Code ('Unsafe Reflection')
 * BadSource: Listen_tcp Read data using a listening tcp connection
 * GoodSource: Set data to a hardcoded class name
 * BadSink:  Instantiate class named in data
 * Flow Variant: 68 Data flow: data passed as a member variable in the "a" class, which is used by a method in another class in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;
using System.Net.Sockets;
using System.Net;

namespace testcases.CWE470_Unsafe_Reflection
{

class CWE470_Unsafe_Reflection__Web_Listen_tcp_68a : AbstractTestCaseWeb
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
        /* FIX: Use a hardcoded class name */
        data = "Testing.test";
        CWE470_Unsafe_Reflection__Web_Listen_tcp_68b.GoodG2BSink(req, resp);
    }
#endif //omitgood
}
}
