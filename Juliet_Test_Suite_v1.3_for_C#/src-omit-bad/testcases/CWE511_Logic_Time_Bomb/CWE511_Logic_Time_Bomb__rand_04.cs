/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE511_Logic_Time_Bomb__rand_04.cs
Label Definition File: CWE511_Logic_Time_Bomb.label.xml
Template File: point-flaw-04.tmpl.cs
*/
/*
* @description
* CWE: 511 Logic Time Bomb
* Sinks: rand
*    GoodSink: If specific random number generated, print to the console
*    BadSink : If specific random number generated, launch an executable
* Flow Variant: 04 Control flow: if(PRIVATE_CONST_TRUE) and if(PRIVATE_CONST_FALSE)
*
* */

using TestCaseSupport;
using System;

using System.Diagnostics;

namespace testcases.CWE511_Logic_Time_Bomb
{
class CWE511_Logic_Time_Bomb__rand_04 : AbstractTestCase
{
    /* The two variables below are declared "const", so a tool should
     * be able to identify that reads of these will always return their
     * initialized values.
     */
    private const bool PRIVATE_CONST_TRUE = true;
    private const bool PRIVATE_CONST_FALSE = false;

#if (!OMITGOOD)
    /* Good1() changes PRIVATE_CONST_TRUE to PRIVATE_CONST_FALSE */
    private void Good1()
    {
        if (PRIVATE_CONST_FALSE)
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
        }
        else
        {
            /* FIX: no backdoor exists */
            if ((new Random()).Next() == 20000)
            {
                IO.WriteLine("Sorry, your license has expired.  Please contact support.");
            }
        }
    }

    /* Good2() reverses the bodies in the if statement */
    private void Good2()
    {
        if (PRIVATE_CONST_TRUE)
        {
            /* FIX: no backdoor exists */
            if ((new Random()).Next() == 20000)
            {
                IO.WriteLine("Sorry, your license has expired.  Please contact support.");
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
