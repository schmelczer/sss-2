/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE476_NULL_Pointer_Dereference__StringBuilder_02.cs
Label Definition File: CWE476_NULL_Pointer_Dereference.label.xml
Template File: sources-sinks-02.tmpl.cs
*/
/*
* @description
* CWE: 476 Null Pointer Dereference
* BadSource:  Set data to null
* GoodSource: Set data to a non-null value
* Sinks:
*    GoodSink: add check to prevent possibility of null dereference
*    BadSink : possibility of null dereference
* Flow Variant: 02 Control flow: if(true) and if(false)
*
* */

using TestCaseSupport;
using System;

using System.Text;


namespace testcases.CWE476_NULL_Pointer_Dereference
{
class CWE476_NULL_Pointer_Dereference__StringBuilder_02 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        StringBuilder data;
        if (true)
        {
            /* POTENTIAL FLAW: data is null */
            data = null;
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        if (true)
        {
            /* POTENTIAL FLAW: null dereference will occur if data is null */
            IO.WriteLine("" + data.Length);
        }
    }
#endif //omitbad

}
}
