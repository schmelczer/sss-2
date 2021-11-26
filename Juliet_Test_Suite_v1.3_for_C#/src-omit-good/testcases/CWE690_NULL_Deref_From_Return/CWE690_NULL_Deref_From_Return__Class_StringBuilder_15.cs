/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE690_NULL_Deref_From_Return__Class_StringBuilder_15.cs
Label Definition File: CWE690_NULL_Deref_From_Return__Class.label.xml
Template File: sources-sinks-15.tmpl.cs
*/
/*
* @description
* CWE: 690 Unchecked return value is null, leading to a null pointer dereference.
* BadSource:  Use a custom method which may return null
* GoodSource: Use a custom method that never returns null
* Sinks: trim
*    GoodSink: Check data for null before calling trim()
*    BadSink : Call trim() on possibly null object
* Flow Variant: 15 Control flow: switch(6) and switch(7)
*
* */

using TestCaseSupport;
using System;

using System.Text;

namespace testcases.CWE690_NULL_Deref_From_Return
{
class CWE690_NULL_Deref_From_Return__Class_StringBuilder_15 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        StringBuilder data;
        switch (6)
        {
        case 6:
            /* POTENTIAL FLAW: Call getStringBuilderBad(), which may return null */
            data = CWE690_NULL_Deref_From_Return__Class_Helper.getStringBuilderBad();
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
            break;
        }
        switch (7)
        {
        case 7:
            /* POTENTIAL FLAW: data could be null */
            string stringTrimmed = data.ToString().Trim();
            IO.WriteLine(stringTrimmed);
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
            break;
        }
    }
#endif //omitbad

}
}
