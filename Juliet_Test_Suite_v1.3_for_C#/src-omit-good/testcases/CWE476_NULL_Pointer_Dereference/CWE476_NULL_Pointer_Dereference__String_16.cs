/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE476_NULL_Pointer_Dereference__String_16.cs
Label Definition File: CWE476_NULL_Pointer_Dereference.label.xml
Template File: sources-sinks-16.tmpl.cs
*/
/*
* @description
* CWE: 476 Null Pointer Dereference
* BadSource:  Set data to null
* GoodSource: Set data to a non-null value
* Sinks:
*    GoodSink: add check to prevent possibility of null dereference
*    BadSink : possibility of null dereference
* Flow Variant: 16 Control flow: while(true)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE476_NULL_Pointer_Dereference
{
class CWE476_NULL_Pointer_Dereference__String_16 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string data;
        while (true)
        {
            /* POTENTIAL FLAW: data is null */
            data = null;
            break;
        }
        while (true)
        {
            /* POTENTIAL FLAW: null dereference will occur if data is null */
            IO.WriteLine("" + data.Length);
            break;
        }
    }
#endif //omitbad

}
}
