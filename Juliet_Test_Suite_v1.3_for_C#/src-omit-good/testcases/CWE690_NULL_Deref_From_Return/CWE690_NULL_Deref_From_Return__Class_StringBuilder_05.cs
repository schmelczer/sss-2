/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE690_NULL_Deref_From_Return__Class_StringBuilder_05.cs
Label Definition File: CWE690_NULL_Deref_From_Return__Class.label.xml
Template File: sources-sinks-05.tmpl.cs
*/
/*
* @description
* CWE: 690 Unchecked return value is null, leading to a null pointer dereference.
* BadSource:  Use a custom method which may return null
* GoodSource: Use a custom method that never returns null
* Sinks: trim
*    GoodSink: Check data for null before calling trim()
*    BadSink : Call trim() on possibly null object
* Flow Variant: 05 Control flow: if(privateTrue) and if(privateFalse)
*
* */
using TestCaseSupport;
using System;

using System.Text;

namespace testcases.CWE690_NULL_Deref_From_Return
{
class CWE690_NULL_Deref_From_Return__Class_StringBuilder_05 : AbstractTestCase
{

    /* The two variables below are not defined as "readonly", but are never
     * assigned any other value, so a tool should be able to identify that
     * reads of these will always return their initialized values.
     */
    private bool privateTrue = true;
    private bool privateFalse = false;
#if (!OMITBAD)
    public override void Bad()
    {
        StringBuilder data;
        if (privateTrue)
        {
            /* POTENTIAL FLAW: Call getStringBuilderBad(), which may return null */
            data = CWE690_NULL_Deref_From_Return__Class_Helper.getStringBuilderBad();
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        if (privateTrue)
        {
            /* POTENTIAL FLAW: data could be null */
            string stringTrimmed = data.ToString().Trim();
            IO.WriteLine(stringTrimmed);
        }
    }
#endif //omitbad

}
}
