/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE681_Incorrect_Conversion_Between_Numeric_Types__double2float_12.cs
Label Definition File: CWE681_Incorrect_Conversion_Between_Numeric_Types.label.xml
Template File: point-flaw-12.tmpl.cs
*/
/*
* @description
* CWE: 681 Incorrect Conversion Between Numeric Types
* Sinks: double2float
*    GoodSink: check for conversion error
*    BadSink : explicit cast
* Flow Variant: 12 Control flow: if(IO.StaticReturnsTrueOrFalse())
*
* */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE681_Incorrect_Conversion_Between_Numeric_Types
{
class CWE681_Incorrect_Conversion_Between_Numeric_Types__double2float_12 : AbstractTestCase
{

#if (!OMITGOOD)
    /* Good1() changes the "if" so that both branches use the GoodSink */
    private void Good1()
    {
        if (IO.StaticReturnsTrueOrFalse())
        {
            try
            {
                double num = 0;
                IO.WriteString("Enter double number (1e50): ");
                try
                {
                    num = Double.Parse(Console.ReadLine());
                }
                catch (FormatException exceptNumberFormat)
                {
                    IO.WriteLine("Error parsing number");
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Error parsing number");
                }
                /* FIX: check for conversion error */
                if (num > float.MaxValue || num < float.MinValue)
                {
                    IO.WriteLine("Error, cannot safely cast this number to a float!");
                    return;
                }
                IO.WriteLine("" + (float)num);
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with console reading");
            }
        }
        else
        {
            try
            {
                double num = 0;
                IO.WriteString("Enter double number (1e50): ");
                try
                {
                    num = Double.Parse(Console.ReadLine());
                }
                catch (FormatException exceptNumberFormat)
                {
                    IO.WriteLine("Error parsing number");
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Error parsing number");
                }
                /* FIX: check for conversion error */
                if (num > float.MaxValue || num < float.MinValue)
                {
                    IO.WriteLine("Error, cannot safely cast this number to a float!");
                    return;
                }
                IO.WriteLine("" + (float)num);
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with console reading");
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
