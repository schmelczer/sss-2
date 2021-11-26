/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE690_NULL_Deref_From_Return__Class_StringBuilder_81a.cs
Label Definition File: CWE690_NULL_Deref_From_Return__Class.label.xml
Template File: sources-sinks-81a.tmpl.cs
*/
/*
 * @description
 * CWE: 690 Unchecked return value is null, leading to a null pointer dereference.
 * BadSource:  Use a custom method which may return null
 * GoodSource: Use a custom method that never returns null
 * Sinks: trim
 *    GoodSink: Check data for null before calling trim()
 *    BadSink : Call trim() on possibly null object
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

using TestCaseSupport;
using System;

using System.Text;

namespace testcases.CWE690_NULL_Deref_From_Return
{
class CWE690_NULL_Deref_From_Return__Class_StringBuilder_81a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        StringBuilder data;
        /* POTENTIAL FLAW: Call getStringBuilderBad(), which may return null */
        data = CWE690_NULL_Deref_From_Return__Class_Helper.getStringBuilderBad();
        CWE690_NULL_Deref_From_Return__Class_StringBuilder_81_base baseObject = new CWE690_NULL_Deref_From_Return__Class_StringBuilder_81_bad();
        baseObject.Action(data );
    }
#endif //omitbad

}
}
