/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE476_NULL_Pointer_Dereference__binary_if_04.cs
Label Definition File: CWE476_NULL_Pointer_Dereference.pointflaw.label.xml
Template File: point-flaw-04.tmpl.cs
*/
/*
* @description
* CWE: 476 NULL Pointer Dereference
* Sinks: binary_if
*    GoodSink: Do not check for null after the object has been dereferenced
*    BadSink : Check for null after an object has already been dereferenced
* Flow Variant: 04 Control flow: if(PRIVATE_CONST_TRUE) and if(PRIVATE_CONST_FALSE)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE476_NULL_Pointer_Dereference
{
class CWE476_NULL_Pointer_Dereference__binary_if_04 : AbstractTestCase
{
    /* The two variables below are declared "const", so a tool should
     * be able to identify that reads of these will always return their
     * initialized values.
     */
    private const bool PRIVATE_CONST_TRUE = true;
    private const bool PRIVATE_CONST_FALSE = false;
#if (!OMITBAD)
    public override void Bad()
    {
        if (PRIVATE_CONST_TRUE)
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
