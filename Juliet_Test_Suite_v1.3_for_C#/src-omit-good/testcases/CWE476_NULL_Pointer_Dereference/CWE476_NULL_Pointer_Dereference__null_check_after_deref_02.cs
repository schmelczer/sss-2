/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE476_NULL_Pointer_Dereference__null_check_after_deref_02.cs
Label Definition File: CWE476_NULL_Pointer_Dereference.pointflaw.label.xml
Template File: point-flaw-02.tmpl.cs
*/
/*
* @description
* CWE: 476 NULL Pointer Dereference
* Sinks: null_check_after_deref
*    GoodSink: Do not check for null after the object has been dereferenced
*    BadSink : Check for null after the object has already been dereferenced
* Flow Variant: 02 Control flow: if(true) and if(false)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE476_NULL_Pointer_Dereference
{
class CWE476_NULL_Pointer_Dereference__null_check_after_deref_02 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (true)
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
