/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__UInt16_console_ReadLine_multiply_12.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-12.tmpl.cs
*/
/*
* @description
* CWE: 191 Integer Underflow
* BadSource: console_ReadLine Read data from the console using ReadLine
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: multiply
*    GoodSink: Ensure there will not be an underflow before multiplying data by 2
*    BadSink : If data is negative, multiply by 2, which can cause an underflow
* Flow Variant: 12 Control flow: if(IO.StaticReturnsTrueOrFalse())
*
* */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__UInt16_console_ReadLine_multiply_12 : AbstractTestCase
{

#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink by changing the first "if" so that
     * both branches use the GoodSource */
    private void GoodG2B()
    {
        ushort data;
        if(IO.StaticReturnsTrueOrFalse())
        {
            /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
            data = 2;
        }
        else
        {
            /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
            data = 2;
        }
        if(IO.StaticReturnsTrueOrFalse())
        {
            if(data < 0) /* ensure we won't have an overflow */
            {
                /* POTENTIAL FLAW: if (data * 2) < ushort.MinValue, this will underflow */
                ushort result = (ushort)(data * 2);
                IO.WriteLine("result: " + result);
            }
        }
        else
        {
            if(data < 0) /* ensure we won't have an overflow */
            {
                /* POTENTIAL FLAW: if (data * 2) < ushort.MinValue, this will underflow */
                ushort result = (ushort)(data * 2);
                IO.WriteLine("result: " + result);
            }
        }
    }

    /* goodB2G() - use badsource and goodsink by changing the second "if" so that
     * both branches use the GoodSink */
    private void GoodB2G()
    {
        ushort data;
        if(IO.StaticReturnsTrueOrFalse())
        {
            /* init data */
            data = 0;
            /* POTENTIAL FLAW: Read data from console with ReadLine*/
            try
            {
                string stringNumber = Console.ReadLine();
                if (stringNumber != null)
                {
                    data = ushort.Parse(stringNumber.Trim());
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
        }
        else
        {
            /* init data */
            data = 0;
            /* POTENTIAL FLAW: Read data from console with ReadLine*/
            try
            {
                string stringNumber = Console.ReadLine();
                if (stringNumber != null)
                {
                    data = ushort.Parse(stringNumber.Trim());
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
        }
        if(IO.StaticReturnsTrueOrFalse())
        {
            if(data < 0) /* ensure we won't have an overflow */
            {
                /* FIX: Add a check to prevent an underflow from occurring */
                if (data > (ushort.MinValue/2))
                {
                    ushort result = (ushort)(data * 2);
                    IO.WriteLine("result: " + result);
                }
                else
                {
                    IO.WriteLine("data value is too small to perform multiplication.");
                }
            }
        }
        else
        {
            if(data < 0) /* ensure we won't have an overflow */
            {
                /* FIX: Add a check to prevent an underflow from occurring */
                if (data > (ushort.MinValue/2))
                {
                    ushort result = (ushort)(data * 2);
                    IO.WriteLine("result: " + result);
                }
                else
                {
                    IO.WriteLine("data value is too small to perform multiplication.");
                }
            }
        }
    }

    public override void Good()

    {
        GoodG2B();
        GoodB2G();
    }
#endif //omitgood
}
}
