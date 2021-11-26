/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__float_console_readLine_modulo_05.cs
Label Definition File: CWE369_Divide_by_Zero__float.label.xml
Template File: sources-sinks-05.tmpl.cs
*/
/*
* @description
* CWE: 369 Divide by zero
* BadSource: console_readLine Read data from the console using readLine
* GoodSource: A hardcoded non-zero number (two)
* Sinks: modulo
*    GoodSink: Check for zero before modulo
*    BadSink : Modulo by a value that may be zero
* Flow Variant: 05 Control flow: if(privateTrue) and if(privateFalse)
*
* */
using TestCaseSupport;
using System;

using System.Web;

using System.IO;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__float_console_readLine_modulo_05 : AbstractTestCase
{

    /* The two variables below are not defined as "readonly", but are never
     * assigned any other value, so a tool should be able to identify that
     * reads of these will always return their initialized values.
     */
    private bool privateTrue = true;
    private bool privateFalse = false;
#if (!OMITBAD)
    public override void Bad()
    {
        float data;
        if (privateTrue)
        {
            data = -1.0f; /* Initialize data */
            {
                /* read user input from console with ReadLine */
                try
                {
                    /* POTENTIAL FLAW: Read data from the console using ReadLine */
                    string stringNumber = Console.ReadLine();
                    if (stringNumber != null) // avoid NPD incidental warnings
                    {
                        try
                        {
                            data = int.Parse(stringNumber.Trim());
                        }
                        catch(FormatException exceptNumberFormat)
                        {
                            IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Number format exception parsing data from string");
                        }
                    }
                }
                catch (IOException exceptIO)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
                }
            }
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0.0f;
        }
        if (privateTrue)
        {
            /* POTENTIAL FLAW: Possibly modulo by zero */
            int result = (int)(100.0 % data);
            IO.WriteLine(result);
        }
    }
#endif //omitbad

}
}
