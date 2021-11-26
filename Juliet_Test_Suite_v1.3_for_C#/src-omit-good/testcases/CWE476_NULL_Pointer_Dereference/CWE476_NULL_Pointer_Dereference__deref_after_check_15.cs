/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE476_NULL_Pointer_Dereference__deref_after_check_15.cs
Label Definition File: CWE476_NULL_Pointer_Dereference.pointflaw.label.xml
Template File: point-flaw-15.tmpl.cs
*/
/*
* @description
* CWE: 476 NULL Pointer Dereference
* Sinks: deref_after_check
*    GoodSink: Do not dereference an object if it is null
*    BadSink : Dereference after checking to see if an object is null
* Flow Variant: 15 Control flow: switch(7)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE476_NULL_Pointer_Dereference
{
class CWE476_NULL_Pointer_Dereference__deref_after_check_15 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        switch (7)
        {
        case 7:
        {
            /* FLAW: Check for null, but still dereference the object */
            string myString = null;
            if (myString == null)
            {
                IO.WriteLine(myString.Length);
            }
        }
        break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
            break;
        }
    }
#endif //omitbad

}
}
