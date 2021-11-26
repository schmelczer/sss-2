/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE690_NULL_Deref_From_Return__Class_StringBuilder_41.cs
Label Definition File: CWE690_NULL_Deref_From_Return__Class.label.xml
Template File: sources-sinks-41.tmpl.cs
*/
/*
 * @description
 * CWE: 690 Unchecked return value is null, leading to a null pointer dereference.
 * BadSource:  Use a custom method which may return null
 * GoodSource: Use a custom method that never returns null
 * Sinks: trim
 *    GoodSink: Check data for null before calling trim()
 *    BadSink : Call trim() on possibly null object
 * Flow Variant: 41 Data flow: data passed as an argument from one method to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Text;

namespace testcases.CWE690_NULL_Deref_From_Return
{
class CWE690_NULL_Deref_From_Return__Class_StringBuilder_41 : AbstractTestCase
{
#if (!OMITBAD)
    private static void BadSink(StringBuilder data )
    {
        /* POTENTIAL FLAW: data could be null */
        string stringTrimmed = data.ToString().Trim();
        IO.WriteLine(stringTrimmed);
    }

    public override void Bad()
    {
        StringBuilder data;
        /* POTENTIAL FLAW: Call getStringBuilderBad(), which may return null */
        data = CWE690_NULL_Deref_From_Return__Class_Helper.getStringBuilderBad();
        BadSink(data  );
    }
#endif //omitbad

}
}
