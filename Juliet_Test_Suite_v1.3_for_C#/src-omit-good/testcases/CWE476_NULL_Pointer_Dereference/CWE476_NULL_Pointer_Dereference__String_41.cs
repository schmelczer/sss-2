/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE476_NULL_Pointer_Dereference__String_41.cs
Label Definition File: CWE476_NULL_Pointer_Dereference.label.xml
Template File: sources-sinks-41.tmpl.cs
*/
/*
 * @description
 * CWE: 476 Null Pointer Dereference
 * BadSource:  Set data to null
 * GoodSource: Set data to a non-null value
 * Sinks:
 *    GoodSink: add check to prevent possibility of null dereference
 *    BadSink : possibility of null dereference
 * Flow Variant: 41 Data flow: data passed as an argument from one method to another in the same class
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE476_NULL_Pointer_Dereference
{
class CWE476_NULL_Pointer_Dereference__String_41 : AbstractTestCase
{
#if (!OMITBAD)
    private static void BadSink(string data )
    {
        /* POTENTIAL FLAW: null dereference will occur if data is null */
        IO.WriteLine("" + data.Length);
    }

    public override void Bad()
    {
        string data;
        /* POTENTIAL FLAW: data is null */
        data = null;
        BadSink(data  );
    }
#endif //omitbad

}
}
