/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE80_XSS__Web_Listen_tcp_73a.cs
Label Definition File: CWE80_XSS__Web.label.xml
Template File: sources-sink-73a.tmpl.cs
*/
/*
 * @description
 * CWE: 80 Cross Site Scripting (XSS)
 * BadSource: Listen_tcp Read data using a listening tcp connection
 * GoodSource: A hardcoded string
 * Sinks: Web
 *    BadSink : Display of data in web page without any encoding or validation
 * Flow Variant: 73 Data flow: data passed in a LinkedList from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections.Generic;
using System;

using System.Web;

using System.IO;
using System.Net.Sockets;
using System.Net;

namespace testcases.CWE80_XSS
{

class CWE80_XSS__Web_Listen_tcp_73a : AbstractTestCaseWeb
{

#if (!OMITGOOD)
    public override void Good(HttpRequest req, HttpResponse resp)
    {
        GoodG2B(req, resp);
    }

    /* goodG2B() - use goodsource and badsink */
    private static void GoodG2B(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* FIX: Use a hardcoded string */
        data = "foo";
        LinkedList<string> dataLinkedList = new LinkedList<string>();
        dataLinkedList.AddLast(data);
        dataLinkedList.AddLast(data);
        dataLinkedList.AddLast(data);
        CWE80_XSS__Web_Listen_tcp_73b.GoodG2BSink(dataLinkedList , req, resp );
    }
#endif //omitgood
}
}
