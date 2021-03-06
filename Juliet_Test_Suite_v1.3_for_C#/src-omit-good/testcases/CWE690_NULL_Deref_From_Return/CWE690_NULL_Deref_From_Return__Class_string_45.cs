/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE690_NULL_Deref_From_Return__Class_string_45.cs
Label Definition File: CWE690_NULL_Deref_From_Return__Class.label.xml
Template File: sources-sinks-45.tmpl.cs
*/
/*
 * @description
 * CWE: 690 Unchecked return value is null, leading to a null pointer dereference.
 * BadSource:  Use a custom method which may return null
 * GoodSource: Use a custom method that never returns null
 * Sinks: trim
 *    GoodSink: Check data for null before calling trim()
 *    BadSink : Call trim() on possibly null object
 * Flow Variant: 45 Data flow: data passed as a private class member variable from one function to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Text;

namespace testcases.CWE690_NULL_Deref_From_Return
{
class CWE690_NULL_Deref_From_Return__Class_string_45 : AbstractTestCase
{

    private String dataBad;
    private String dataGoodG2B;
    private String dataGoodB2G;
#if (!OMITBAD)
    private void BadSink()
    {
        String data = dataBad;
        /* POTENTIAL FLAW: data could be null */
        string stringTrimmed = data.Trim();
        IO.WriteLine(stringTrimmed);
    }

    public override void Bad()
    {
        String data;
        /* POTENTIAL FLAW: Call getStringBad(), which may return null */
        data = CWE690_NULL_Deref_From_Return__Class_Helper.getStringBad();
        dataBad = data;
        BadSink();
    }
#endif //omitbad

}
}
