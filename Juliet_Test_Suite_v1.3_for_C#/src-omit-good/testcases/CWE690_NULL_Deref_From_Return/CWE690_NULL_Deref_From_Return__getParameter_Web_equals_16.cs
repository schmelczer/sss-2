/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE690_NULL_Deref_From_Return__getParameter_Web_equals_16.cs
Label Definition File: CWE690_NULL_Deref_From_Return.label.xml
Template File: sources-sinks-16.tmpl.cs
*/
/*
* @description
* CWE: 690 Unchecked return value is null, leading to a null pointer dereference.
* BadSource: getParameter_Web Set data to return of getParameter_Web
* GoodSource: Set data to fixed, non-null String
* Sinks: equals
*    GoodSink: Call equals() on string literal (that is not null)
*    BadSink : Call equals() on possibly null object
* Flow Variant: 16 Control flow: while(true)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE690_NULL_Deref_From_Return
{
class CWE690_NULL_Deref_From_Return__getParameter_Web_equals_16 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        while (true)
        {
            /* POTENTIAL FLAW: data may be set to null */
            data = req.QueryString["CWE690"];
            break;
        }
        while (true)
        {
            /* POTENTIAL FLAW: data could be null */
            if(data.Equals("CWE690"))
            {
                IO.WriteLine("data is CWE690");
            }
            break;
        }
    }
#endif //omitbad

}
}
