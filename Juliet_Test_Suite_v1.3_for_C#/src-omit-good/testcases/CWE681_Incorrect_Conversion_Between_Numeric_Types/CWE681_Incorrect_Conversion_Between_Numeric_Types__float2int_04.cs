/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE681_Incorrect_Conversion_Between_Numeric_Types__float2int_04.cs
Label Definition File: CWE681_Incorrect_Conversion_Between_Numeric_Types.label.xml
Template File: point-flaw-04.tmpl.cs
*/
/*
* @description
* CWE: 681 Incorrect Conversion Between Numeric Types
* Sinks: float2int
*    GoodSink: check value before conversion
*    BadSink : conversion may be unsafe
* Flow Variant: 04 Control flow: if(PRIVATE_CONST_TRUE) and if(PRIVATE_CONST_FALSE)
*
* */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE681_Incorrect_Conversion_Between_Numeric_Types
{
class CWE681_Incorrect_Conversion_Between_Numeric_Types__float2int_04 : AbstractTestCase
{
    /* The two variables below are declared "const", so a tool should
     * be able to identify that reads of these will always return their
     * initialized values.
     */
    private const bool PRIVATE_CONST_TRUE = true;
    private const bool PRIVATE_CONST_FALSE = false;
#if (!OMITBAD)
    public override void Bad()
    {
        if (PRIVATE_CONST_TRUE)
        {
            try
            {
                /* Enter: 1e20, result should be -2147483648 (for bad case) */
                float num = 0;
                IO.WriteString("Enter float number (1e20): ");
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
                IO.WriteLine("" + (int)num);
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
