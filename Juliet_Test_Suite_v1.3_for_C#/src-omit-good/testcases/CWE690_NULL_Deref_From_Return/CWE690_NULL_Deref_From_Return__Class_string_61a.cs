/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE690_NULL_Deref_From_Return__Class_string_61a.cs
Label Definition File: CWE690_NULL_Deref_From_Return__Class.label.xml
Template File: sources-sinks-61a.tmpl.cs
*/
/*
 * @description
 * CWE: 690 Unchecked return value is null, leading to a null pointer dereference.
 * BadSource:  Use a custom method which may return null
 * GoodSource: Use a custom method that never returns null
 * Sinks: trim
 *    GoodSink: Check data for null before calling trim()
 *    BadSink : Call trim() on possibly null object
 * Flow Variant: 61 Data flow: data returned from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Text;

namespace testcases.CWE690_NULL_Deref_From_Return
{
class CWE690_NULL_Deref_From_Return__Class_string_61a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        String data = CWE690_NULL_Deref_From_Return__Class_string_61b.BadSource();
        /* POTENTIAL FLAW: data could be null */
        string stringTrimmed = data.Trim();
        IO.WriteLine(stringTrimmed);
    }
#endif //omitbad

}
}
