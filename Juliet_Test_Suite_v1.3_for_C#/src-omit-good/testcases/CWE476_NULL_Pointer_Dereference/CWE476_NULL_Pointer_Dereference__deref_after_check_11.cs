/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE476_NULL_Pointer_Dereference__deref_after_check_11.cs
Label Definition File: CWE476_NULL_Pointer_Dereference.pointflaw.label.xml
Template File: point-flaw-11.tmpl.cs
*/
/*
* @description
* CWE: 476 NULL Pointer Dereference
* Sinks: deref_after_check
*    GoodSink: Do not dereference an object if it is null
*    BadSink : Dereference after checking to see if an object is null
* Flow Variant: 11 Control flow: if(IO.StaticReturnsTrue()) and if(IO.StaticReturnsFalse())
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE476_NULL_Pointer_Dereference
{
class CWE476_NULL_Pointer_Dereference__deref_after_check_11 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (IO.StaticReturnsTrue())
        {
            {
                /* FLAW: Check for null, but still dereference the object */
                string myString = null;
                if (myString == null)
                {
                    IO.WriteLine(myString.Length);
                }
            }
        }
    }
#endif //omitbad

}
}
