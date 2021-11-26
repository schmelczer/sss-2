/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE476_NULL_Pointer_Dereference__binary_if_03.cs
Label Definition File: CWE476_NULL_Pointer_Dereference.pointflaw.label.xml
Template File: point-flaw-03.tmpl.cs
*/
/*
* @description
* CWE: 476 NULL Pointer Dereference
* Sinks: binary_if
*    GoodSink: Do not check for null after the object has been dereferenced
*    BadSink : Check for null after an object has already been dereferenced
* Flow Variant: 03 Control flow: if(5==5) and if(5!=5)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE476_NULL_Pointer_Dereference
{
class CWE476_NULL_Pointer_Dereference__binary_if_03 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (5 == 5)
        {
            {
                string myString = null;
                /* FLAW: Using a single & in the if statement will cause both sides of the expression to be evaluated
                 * thus causing a NPD */
                if ((myString != null) & (myString.Length > 0))
                {
                    IO.WriteLine("The string length is greater than 0");
                }
            }
        }
    }
#endif //omitbad

}
}
