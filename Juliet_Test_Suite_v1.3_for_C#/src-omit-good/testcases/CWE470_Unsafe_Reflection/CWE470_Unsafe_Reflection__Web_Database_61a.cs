/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE470_Unsafe_Reflection__Web_Database_61a.cs
Label Definition File: CWE470_Unsafe_Reflection__Web.label.xml
Template File: sources-sink-61a.tmpl.cs
*/
/*
 * @description
 * CWE: 470 Use of Externally-Controlled Input to Select Classes or Code ('Unsafe Reflection')
 * BadSource: Database Read data from a database
 * GoodSource: Set data to a hardcoded class name
 * Sinks:
 *    BadSink : Instantiate class named in data
 * Flow Variant: 61 Data flow: data returned from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE470_Unsafe_Reflection
{
class CWE470_Unsafe_Reflection__Web_Database_61a : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data = CWE470_Unsafe_Reflection__Web_Database_61b.BadSource(req, resp);
        /* POTENTIAL FLAW: Instantiate object of class named in data (which may be from external input) */
        var container = Activator.CreateInstance(null, data);
        Object tempClassObj = container.Unwrap();
        IO.WriteLine(tempClassObj.GetType().ToString()); /* Use tempClassObj in some way */
    }
#endif //omitbad

}
}
