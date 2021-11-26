/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE681_Incorrect_Conversion_Between_Numeric_Types__floatNaN2int_17.cs
Label Definition File: CWE681_Incorrect_Conversion_Between_Numeric_Types.label.xml
Template File: point-flaw-17.tmpl.cs
*/
/*
* @description
* CWE: 681 Incorrect Conversion Between Numeric Types
* Sinks: floatNaN2int
*    GoodSink: check for negative sqrt
*    BadSink : sqrt to unchecked value
* Flow Variant: 17 Control flow: for loops
*
* */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE681_Incorrect_Conversion_Between_Numeric_Types
{
class CWE681_Incorrect_Conversion_Between_Numeric_Types__floatNaN2int_17 : AbstractTestCase
{

#if (!OMITGOOD)
    /* Good1() use the GoodSinkBody in the for statement */
    private void Good1()
    {
        for(int k = 0; k < 1; k++)
        {
            try
            {
                IO.WriteString("Enter float number: ");
                float num = 0;
                try
                {
                    num = float.Parse(Console.ReadLine());
                }
                catch (FormatException exceptNumberFormat)
                {
                    IO.WriteLine("Error parsing number");
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Error parsing number");
                }
                /* FIX: check for sign */
                if (num < 0)
                {
                    IO.WriteLine("Negative Number");
                }
                else
                {
                    IO.WriteLine("" + (int)(Math.Sqrt(num)));
                }
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
            }
        }
    }

    public override void Good()
    {
        Good1();
    }
#endif //omitgood
}
}
