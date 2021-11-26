/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE470_Unsafe_Reflection__Web_NetClient_16.cs
Label Definition File: CWE470_Unsafe_Reflection__Web.label.xml
Template File: sources-sink-16.tmpl.cs
*/
/*
* @description
* CWE: 470 Use of Externally-Controlled Input to Select Classes or Code ('Unsafe Reflection')
* BadSource: NetClient Read data from a web server with WebClient
* GoodSource: Set data to a hardcoded class name
* BadSink:  Instantiate class named in data
* Flow Variant: 16 Control flow: while(true)
*
* */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;
using System.Net;

namespace testcases.CWE470_Unsafe_Reflection
{

class CWE470_Unsafe_Reflection__Web_NetClient_16 : AbstractTestCaseWeb
{

#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    private void GoodG2B(HttpRequest req, HttpResponse resp)
    {
        string data;
        while (true)
        {
            /* FIX: Use a hardcoded class name */
            data = "Testing.test";
            break;
        }
        /* POTENTIAL FLAW: Instantiate object of class named in data (which may be from external input) */
        var container = Activator.CreateInstance(null, data);
        Object tempClassObj = container.Unwrap();
        IO.WriteLine(tempClassObj.GetType().ToString()); /* Use tempClassObj in some way */
    }

    public override void Good(HttpRequest req, HttpResponse resp)
    {
        GoodG2B(req, resp);
    }
#endif //omitgood
}
}
