/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE476_NULL_Pointer_Dereference__String_42.cs
Label Definition File: CWE476_NULL_Pointer_Dereference.label.xml
Template File: sources-sinks-42.tmpl.cs
*/
/*
 * @description
 * CWE: 476 Null Pointer Dereference
 * BadSource:  Set data to null
 * GoodSource: Set data to a non-null value
 * Sinks:
 *    GoodSink: add check to prevent possibility of null dereference
 *    BadSink : possibility of null dereference
 * Flow Variant: 42 Data flow: data returned from one method to another in the same class
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE476_NULL_Pointer_Dereference
{
class CWE476_NULL_Pointer_Dereference__String_42 : AbstractTestCase
{
#if (!OMITBAD)
    private static string BadSource()
    {
        string data;
        /* POTENTIAL FLAW: data is null */
        data = null;
        return data;
    }

    public override void Bad()
    {
        string data = BadSource();
        /* POTENTIAL FLAW: null dereference will occur if data is null */
        IO.WriteLine("" + data.Length);
    }
#endif //omitbad

}
}
