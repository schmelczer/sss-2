/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE476_NULL_Pointer_Dereference__null_check_after_deref_14.cs
Label Definition File: CWE476_NULL_Pointer_Dereference.pointflaw.label.xml
Template File: point-flaw-14.tmpl.cs
*/
/*
* @description
* CWE: 476 NULL Pointer Dereference
* Sinks: null_check_after_deref
*    GoodSink: Do not check for null after the object has been dereferenced
*    BadSink : Check for null after the object has already been dereferenced
* Flow Variant: 14 Control flow: if(IO.staticFive==5) and if(IO.staticFive!=5)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE476_NULL_Pointer_Dereference
{
class CWE476_NULL_Pointer_Dereference__null_check_after_deref_14 : AbstractTestCase
{

#if (!OMITGOOD)
    /* Good1() changes IO.staticFive==5 to IO.staticFive!=5 */
    private void Good1()
    {
        if (IO.staticFive != 5)
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
        }
        else
        {
            {
                string myString = null;
                myString = "Hello";
                IO.WriteLine(myString.Length);
                /* FIX: Don't check for null since we wouldn't reach this line if the object was null */
                myString = "my, how I've changed";
                IO.WriteLine(myString.Length);
            }
        }
    }

    /* Good2() reverses the bodies in the if statement */
    private void Good2()
    {
        if (IO.staticFive == 5)
        {
            {
                string myString = null;
                myString = "Hello";
                IO.WriteLine(myString.Length);
                /* FIX: Don't check for null since we wouldn't reach this line if the object was null */
                myString = "my, how I've changed";
                IO.WriteLine(myString.Length);
            }
        }
    }

    public override void Good()
    {
        Good1();
        Good2();
    }
#endif //omitgood
}
}
