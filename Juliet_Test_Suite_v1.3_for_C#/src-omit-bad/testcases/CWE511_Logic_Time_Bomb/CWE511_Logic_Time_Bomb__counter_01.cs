/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE511_Logic_Time_Bomb__counter_01.cs
Label Definition File: CWE511_Logic_Time_Bomb.label.xml
Template File: point-flaw-01.tmpl.cs
*/
/*
* @description
* CWE: 511 Logic Time Bomb
* Sinks: counter
*    GoodSink: If counter reaches a certain value, print to the console
*    BadSink : If counter reaches a certain value, launch an executable
* Flow Variant: 01 Baseline
*
* */

using TestCaseSupport;
using System;

using System.Diagnostics;

namespace testcases.CWE511_Logic_Time_Bomb
{
class CWE511_Logic_Time_Bomb__counter_01 : AbstractTestCase
{

#if (!OMITGOOD)
    public override void Good()
    {
        Good1();
    }

    private void Good1()
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
#endif //omitgood
}
}
