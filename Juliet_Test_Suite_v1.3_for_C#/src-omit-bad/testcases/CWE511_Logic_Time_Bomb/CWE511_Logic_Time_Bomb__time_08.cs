/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE511_Logic_Time_Bomb__time_08.cs
Label Definition File: CWE511_Logic_Time_Bomb.label.xml
Template File: point-flaw-08.tmpl.cs
*/
/*
* @description
* CWE: 511 Logic Time Bomb
* Sinks: time
*    GoodSink: after a certain date, print to the console
*    BadSink : after a certain date, launch an executable
* Flow Variant: 08 Control flow: if(PrivateReturnsTrue()) and if(PrivateReturnsFalse())
*
* */

using TestCaseSupport;
using System;

using System.Diagnostics;

namespace testcases.CWE511_Logic_Time_Bomb
{
class CWE511_Logic_Time_Bomb__time_08 : AbstractTestCase
{
    /* The methods below always return the same value, so a tool
     * should be able to figure out that every call to these
     * methods will return true or return false.
     */
    private static bool PrivateReturnsTrue()
    {
        return true;
    }

    private static bool PrivateReturnsFalse()
    {
        return false;
    }

#if (!OMITGOOD)
    /* Good1() changes PrivateReturnsTrue() to privateReturnsFalse() */
    private void Good1()
    {
        if (PrivateReturnsFalse())
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
        }
        else
        {
            DateTime dateNow = DateTime.Now;
            DateTime dateCheck = new DateTime(2030, 1, 1);
            /* FIX: no backdoor exists */
            if (dateNow > dateCheck)
            {
                IO.WriteLine("Sorry, your license has expired.  Please contact support.");
            }
        }
    }

    /* Good2() reverses the bodies in the if statement */
    private void Good2()
    {
        if (PrivateReturnsTrue())
        {
            DateTime dateNow = DateTime.Now;
            DateTime dateCheck = new DateTime(2030, 1, 1);
            /* FIX: no backdoor exists */
            if (dateNow > dateCheck)
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
