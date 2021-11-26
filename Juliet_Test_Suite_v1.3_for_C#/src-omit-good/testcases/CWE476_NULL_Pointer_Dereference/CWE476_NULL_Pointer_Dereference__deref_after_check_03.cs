/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE476_NULL_Pointer_Dereference__deref_after_check_03.cs
Label Definition File: CWE476_NULL_Pointer_Dereference.pointflaw.label.xml
Template File: point-flaw-03.tmpl.cs
*/
/*
* @description
* CWE: 476 NULL Pointer Dereference
* Sinks: deref_after_check
*    GoodSink: Do not dereference an object if it is null
*    BadSink : Dereference after checking to see if an object is null
* Flow Variant: 03 Control flow: if(5==5) and if(5!=5)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE476_NULL_Pointer_Dereference
{
class CWE476_NULL_Pointer_Dereference__deref_after_check_03 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (5 == 5)
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
