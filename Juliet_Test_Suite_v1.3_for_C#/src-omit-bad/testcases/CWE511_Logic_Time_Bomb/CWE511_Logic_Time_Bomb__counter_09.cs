/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE511_Logic_Time_Bomb__counter_09.cs
Label Definition File: CWE511_Logic_Time_Bomb.label.xml
Template File: point-flaw-09.tmpl.cs
*/
/*
* @description
* CWE: 511 Logic Time Bomb
* Sinks: counter
*    GoodSink: If counter reaches a certain value, print to the console
*    BadSink : If counter reaches a certain value, launch an executable
* Flow Variant: 09 Control flow: if(IO.STATIC_READONLY_TRUE) and if(IO.STATIC_READONLY_FALSE)
*
* */

using TestCaseSupport;
using System;

using System.Diagnostics;

namespace testcases.CWE511_Logic_Time_Bomb
{
class CWE511_Logic_Time_Bomb__counter_09 : AbstractTestCase
{

#if (!OMITGOOD)
    /* Good1() changes IO.STATIC_READONLY_TRUE to IO.STATIC_READONLY_FALSE */
    private void Good1()
    {
        if (IO.STATIC_READONLY_FALSE)
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
        }
        else
        {
            int count = 0;
            do
            {
                /* FIX: no backdoor exists */
                if (count == 20000)
                {
                    IO.WriteLine("Sorry, your license has expired.  Please contact support.");
                }
                count++;
            }
            while (count < int.MaxValue);
        }
    }

    /* Good2() reverses the bodies in the if statement */
    private void Good2()
    {
        if (IO.STATIC_READONLY_TRUE)
        {
            int count = 0;
            do
            {
                /* FIX: no backdoor exists */
                if (count == 20000)
                {
                    IO.WriteLine("Sorry, your license has expired.  Please contact support.");
                }
                count++;
            }
            while (count < int.MaxValue);
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
