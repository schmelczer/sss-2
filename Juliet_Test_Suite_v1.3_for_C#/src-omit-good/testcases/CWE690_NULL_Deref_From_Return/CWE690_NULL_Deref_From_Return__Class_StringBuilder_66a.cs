/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE690_NULL_Deref_From_Return__Class_StringBuilder_66a.cs
Label Definition File: CWE690_NULL_Deref_From_Return__Class.label.xml
Template File: sources-sinks-66a.tmpl.cs
*/
/*
 * @description
 * CWE: 690 Unchecked return value is null, leading to a null pointer dereference.
 * BadSource:  Use a custom method which may return null
 * GoodSource: Use a custom method that never returns null
 * Sinks: trim
 *    GoodSink: Check data for null before calling trim()
 *    BadSink : Call trim() on possibly null object
 * Flow Variant: 66 Data flow: data passed in an array from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Text;

namespace testcases.CWE690_NULL_Deref_From_Return
{
class CWE690_NULL_Deref_From_Return__Class_StringBuilder_66a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        StringBuilder data;
        /* POTENTIAL FLAW: Call getStringBuilderBad(), which may return null */
        data = CWE690_NULL_Deref_From_Return__Class_Helper.getStringBuilderBad();
        StringBuilder[] dataArray = new StringBuilder[5];
        dataArray[2] = data;
        CWE690_NULL_Deref_From_Return__Class_StringBuilder_66b.BadSink(dataArray  );
    }
#endif //omitbad

}
}
