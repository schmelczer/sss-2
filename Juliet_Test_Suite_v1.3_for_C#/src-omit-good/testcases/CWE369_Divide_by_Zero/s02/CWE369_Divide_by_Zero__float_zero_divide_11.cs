/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__float_zero_divide_11.cs
Label Definition File: CWE369_Divide_by_Zero__float.label.xml
Template File: sources-sinks-11.tmpl.cs
*/
/*
* @description
* CWE: 369 Divide by zero
* BadSource: zero Set data to a hardcoded value of zero
* GoodSource: A hardcoded non-zero number (two)
* Sinks: divide
*    GoodSink: Check for zero before dividing
*    BadSink : Dividing by a value that may be zero
* Flow Variant: 11 Control flow: if(IO.StaticReturnsTrue()) and if(IO.StaticReturnsFalse())
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__float_zero_divide_11 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        float data;
        if (IO.StaticReturnsTrue())
        {
            data = 0.0f; /* POTENTIAL FLAW: data is set to zero */
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0.0f;
        }
        if(IO.StaticReturnsTrue())
        {
            /* POTENTIAL FLAW: Possibly divide by zero */
            int result = (int)(100.0 / data);
            IO.WriteLine(result);
        }
    }
#endif //omitbad

}
}
