/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE476_NULL_Pointer_Dereference__String_45.cs
Label Definition File: CWE476_NULL_Pointer_Dereference.label.xml
Template File: sources-sinks-45.tmpl.cs
*/
/*
 * @description
 * CWE: 476 Null Pointer Dereference
 * BadSource:  Set data to null
 * GoodSource: Set data to a non-null value
 * Sinks:
 *    GoodSink: add check to prevent possibility of null dereference
 *    BadSink : possibility of null dereference
 * Flow Variant: 45 Data flow: data passed as a private class member variable from one function to another in the same class
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE476_NULL_Pointer_Dereference
{
class CWE476_NULL_Pointer_Dereference__String_45 : AbstractTestCase
{

    private string dataBad;
    private string dataGoodG2B;
    private string dataGoodB2G;
#if (!OMITBAD)
    private void BadSink()
    {
        string data = dataBad;
        /* POTENTIAL FLAW: null dereference will occur if data is null */
        IO.WriteLine("" + data.Length);
    }

    public override void Bad()
    {
        string data;
        /* POTENTIAL FLAW: data is null */
        data = null;
        dataBad = data;
        BadSink();
    }
#endif //omitbad

}
}
