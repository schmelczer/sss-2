/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__Short_console_ReadLine_multiply_54a.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-54a.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: console_ReadLine Read data from the console using ReadLine
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an underflow before multiplying data by 2
 *    BadSink : If data is negative, multiply by 2, which can cause an underflow
 * Flow Variant: 54 Data flow: data passed as an argument from one method through three others to a fifth; all five functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__Short_console_ReadLine_multiply_54a : AbstractTestCase
{

#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
        GoodB2G();
    }

    /* goodG2B() - use goodsource and badsink */
    private void GoodG2B()
    {
        short data;
        /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
        data = 2;
        CWE191_Integer_Underflow__Short_console_ReadLine_multiply_54b.GoodG2BSink(data );
    }

    /* goodB2G() - use badsource and goodsink */
    private void GoodB2G()
    {
        short data;
        /* init data */
        data = 0;
        /* POTENTIAL FLAW: Read data from console with ReadLine*/
        try
        {
            string stringNumber = Console.ReadLine();
            if (stringNumber != null)
            {
                data = short.Parse(stringNumber.Trim());
            }
        }
        catch (IOException exceptIO)
        {
            IO.Logger.Log(NLog.LogLevel.Warn, "Error with stream reading", exceptIO);
        }
        catch (FormatException exceptNumberFormat)
        {
            IO.Logger.Log(NLog.LogLevel.Warn, "Error with number parsing", exceptNumberFormat);
        }
        CWE191_Integer_Underflow__Short_console_ReadLine_multiply_54b.GoodB2GSink(data );
    }
#endif //omitgood
}
}
