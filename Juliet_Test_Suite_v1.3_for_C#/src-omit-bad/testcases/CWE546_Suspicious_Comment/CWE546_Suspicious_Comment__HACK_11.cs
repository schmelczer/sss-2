/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE546_Suspicious_Comment__HACK_11.cs
Label Definition File: CWE546_Suspicious_Comment.label.xml
Template File: point-flaw-11.tmpl.cs
*/
/*
* @description
* CWE: 546 Suspicious Comment
* Sinks: HACK
*    GoodSink: does not contain suspicious comment
*    BadSink : contains suspicious comment
* Flow Variant: 11 Control flow: if(IO.StaticReturnsTrue()) and if(IO.StaticReturnsFalse())
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE546_Suspicious_Comment
{
class CWE546_Suspicious_Comment__HACK_11 : AbstractTestCase
{

#if (!OMITGOOD)
    /* good1() changes IO.StaticReturnsTrue() to IO.StaticReturnsFalse() */
    private void Good1()
    {
        if (IO.StaticReturnsFalse())
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
        }
        else
        {
            /* FIX: don't have those types of comments :) */
            IO.WriteLine("This a test of the emergency broadcast system");
        }
    }

    /* good2() reverses the bodies in the if statement */
    private void Good2()
    {
        if (IO.StaticReturnsTrue())
        {
            /* FIX: don't have those types of comments :) */
            IO.WriteLine("This a test of the emergency broadcast system");
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
