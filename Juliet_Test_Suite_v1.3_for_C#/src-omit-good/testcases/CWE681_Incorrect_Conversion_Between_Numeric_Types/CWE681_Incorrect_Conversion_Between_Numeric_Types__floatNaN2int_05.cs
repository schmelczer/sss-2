/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE681_Incorrect_Conversion_Between_Numeric_Types__floatNaN2int_05.cs
Label Definition File: CWE681_Incorrect_Conversion_Between_Numeric_Types.label.xml
Template File: point-flaw-05.tmpl.cs
*/
/*
* @description
* CWE: 681 Incorrect Conversion Between Numeric Types
* Sinks: floatNaN2int
*    GoodSink: check for negative sqrt
*    BadSink : sqrt to unchecked value
* Flow Variant: 05 Control flow: if(privateTrue) and if(privateFalse)
*
* */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE681_Incorrect_Conversion_Between_Numeric_Types
{
class CWE681_Incorrect_Conversion_Between_Numeric_Types__floatNaN2int_05 : AbstractTestCase
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
        if (privateTrue)
        {
            try
            {
                /*  * Enter: -2.0, result should be -2147483648 (for bad case)
                 *
                 * Square root of a negative number is NaN. NaN when casted to int is -2147483648.
                 */
                float num = 0;
                IO.WriteString("Enter float number (-2.0): ");
                try
                {
                    num = float.Parse(Console.ReadLine());
                }
                catch (FormatException exceptNumberFormat)
                {
                    IO.WriteLine("Error parsing number");
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Error parsing number");
                }
                /* FLAW: should not cast without checking if conversion is safe */
                IO.WriteLine("" + (int)(Math.Sqrt(num)));
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
            }
        }
    }
#endif //omitbad

}
}
