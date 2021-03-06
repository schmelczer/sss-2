/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE470_Unsafe_Reflection__Web_QueryString_Web_31.cs
Label Definition File: CWE470_Unsafe_Reflection__Web.label.xml
Template File: sources-sink-31.tmpl.cs
*/
/*
 * @description
 * CWE: 470 Use of Externally-Controlled Input to Select Classes or Code ('Unsafe Reflection')
 * BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
 * GoodSource: Set data to a hardcoded class name
 * Sinks:
 *    BadSink : Instantiate class named in data
 * Flow Variant: 31 Data flow: make a copy of data within the same method
 *
 * */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE470_Unsafe_Reflection
{

class CWE470_Unsafe_Reflection__Web_QueryString_Web_31 : AbstractTestCaseWeb
{

#if (!OMITGOOD)
    public override void Good(HttpRequest req, HttpResponse resp)
    {
        GoodG2B(req, resp);
    }

    /* goodG2B() - use goodsource and badsink */
    private void GoodG2B(HttpRequest req, HttpResponse resp)
    {
        string dataCopy;
        {
            string data;
            /* FIX: Use a hardcoded class name */
            data = "Testing.test";
            dataCopy = data;
        }
        {
            string data = dataCopy;
            /* POTENTIAL FLAW: Instantiate object of class named in data (which may be from external input) */
            var container = Activator.CreateInstance(null, data);
            Object tempClassObj = container.Unwrap();
            IO.WriteLine(tempClassObj.GetType().ToString()); /* Use tempClassObj in some way */
        }
    }
#endif //omitgood
}
}
