/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE476_NULL_Pointer_Dereference__null_check_after_deref_04.cs
Label Definition File: CWE476_NULL_Pointer_Dereference.pointflaw.label.xml
Template File: point-flaw-04.tmpl.cs
*/
/*
* @description
* CWE: 476 NULL Pointer Dereference
* Sinks: null_check_after_deref
*    GoodSink: Do not check for null after the object has been dereferenced
*    BadSink : Check for null after the object has already been dereferenced
* Flow Variant: 04 Control flow: if(PRIVATE_CONST_TRUE) and if(PRIVATE_CONST_FALSE)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE476_NULL_Pointer_Dereference
{
class CWE476_NULL_Pointer_Dereference__null_check_after_deref_04 : AbstractTestCase
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
                myString = "Hello";
                IO.WriteLine(myString.Length);
                /* FLAW: Check for null after dereferencing the object. This null check is unnecessary. */
                if (myString != null)
                {
                    myString = "my, how I've changed";
                }
                IO.WriteLine(myString.Length);
            }
        }
    }
#endif //omitbad

}
}
