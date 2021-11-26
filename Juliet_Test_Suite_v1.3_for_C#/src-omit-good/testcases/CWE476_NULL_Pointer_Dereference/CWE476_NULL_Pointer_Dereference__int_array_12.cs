/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE476_NULL_Pointer_Dereference__int_array_12.cs
Label Definition File: CWE476_NULL_Pointer_Dereference.label.xml
Template File: sources-sinks-12.tmpl.cs
*/
/*
* @description
* CWE: 476 Null Pointer Dereference
* BadSource:  Set data to null
* GoodSource: Set data to a non-null value
* Sinks:
*    GoodSink: add check to prevent possibility of null dereference
*    BadSink : possibility of null dereference
* Flow Variant: 12 Control flow: if(IO.StaticReturnsTrueOrFalse())
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE476_NULL_Pointer_Dereference
{
class CWE476_NULL_Pointer_Dereference__int_array_12 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        int[] data;
        if(IO.StaticReturnsTrueOrFalse())
        {
            /* POTENTIAL FLAW: data is null */
            data = null;
        }
        else
        {
            /* FIX: hardcode data to non-null */
            data = new int[5];
        }
        if(IO.StaticReturnsTrueOrFalse())
        {
            /* POTENTIAL FLAW: null dereference will occur if data is null */
            IO.WriteLine("" + data.Length);
        }
        else
        {
            /* FIX: validate that data is non-null */
            if (data != null)
            {
                IO.WriteLine("" + data.Length);
            }
            else
            {
                IO.WriteLine("data is null");
            }
        }
    }
#endif //omitbad

}
}
