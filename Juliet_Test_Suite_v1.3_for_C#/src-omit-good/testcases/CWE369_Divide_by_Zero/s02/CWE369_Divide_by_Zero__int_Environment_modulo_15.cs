/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__int_Environment_modulo_15.cs
Label Definition File: CWE369_Divide_by_Zero__int.label.xml
Template File: sources-sinks-15.tmpl.cs
*/
/*
* @description
* CWE: 369 Divide by zero
* BadSource: Environment Read data from an environment variable
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: modulo
*    GoodSink: Check for zero before modulo
*    BadSink : Modulo by a value that may be zero
* Flow Variant: 15 Control flow: switch(6) and switch(7)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__int_Environment_modulo_15 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        int data;
        switch (6)
        {
        case 6:
            data = int.MinValue; /* Initialize data */
            /* get environment variable ADD */
            /* POTENTIAL FLAW: Read data from an environment variable */
            {
                string stringNumber = Environment.GetEnvironmentVariable("ADD");
                if (stringNumber != null) // avoid NPD incidental warnings
                {
                    try
                    {
                        data = int.Parse(stringNumber.Trim());
                    }
                    catch (FormatException exceptNumberFormat)
                    {
                        IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Number format exception parsing data from string");
                    }
                }
            }
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0;
            break;
        }
        switch (7)
        {
        case 7:
            /* POTENTIAL FLAW: Zero modulus will cause an issue.  An integer division will
            result in an exception.  */
            IO.WriteLine("100%" + data + " = " + (100 % data) + "\n");
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
            break;
        }
    }
#endif //omitbad

}
}