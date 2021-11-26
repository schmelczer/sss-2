/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE690_NULL_Deref_From_Return__getParameter_Web_equals_04.cs
Label Definition File: CWE690_NULL_Deref_From_Return.label.xml
Template File: sources-sinks-04.tmpl.cs
*/
/*
* @description
* CWE: 690 Unchecked return value is null, leading to a null pointer dereference.
* BadSource: getParameter_Web Set data to return of getParameter_Web
* GoodSource: Set data to fixed, non-null String
* Sinks: equals
*    GoodSink: Call equals() on string literal (that is not null)
*    BadSink : Call equals() on possibly null object
* Flow Variant: 04 Control flow: if(PRIVATE_CONST_TRUE) and if(PRIVATE_CONST_FALSE)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE690_NULL_Deref_From_Return
{
class CWE690_NULL_Deref_From_Return__getParameter_Web_equals_04 : AbstractTestCaseWeb
{

    /* The two variables below are declared "const", so a tool should
     * be able to identify that reads of these will always return their
     * initialized values.
     */
    private const bool PRIVATE_CONST_TRUE = true;
    private const bool PRIVATE_CONST_FALSE = false;
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        if (PRIVATE_CONST_TRUE)
        {
            /* POTENTIAL FLAW: data may be set to null */
            data = req.QueryString["CWE690"];
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        if (PRIVATE_CONST_TRUE)
        {
            /* POTENTIAL FLAW: data could be null */
            if(data.Equals("CWE690"))
            {
                IO.WriteLine("data is CWE690");
            }
        }
    }
#endif //omitbad

}
}
