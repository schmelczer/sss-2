/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__UInt32_console_ReadLine_sub_21.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-21.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: console_ReadLine Read data from the console using ReadLine
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: sub
 *    GoodSink: Ensure there will not be an underflow before subtracting 1 from data
 *    BadSink : Subtract 1 from data, which can cause an Underflow
 * Flow Variant: 21 Control flow: Flow controlled by value of a private variable. All functions contained in one file.
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__UInt32_console_ReadLine_sub_21 : AbstractTestCase
{

    /* The variable below is used to drive control flow in the sink function */
    private bool badPrivate = false;
#if (!OMITBAD)
    public override void Bad()
    {
        uint data;
        /* init data */
        data = 0;
        /* POTENTIAL FLAW: Read data from console with ReadLine*/
        try
        {
            string stringNumber = Console.ReadLine();
            if (stringNumber != null)
            {
                data = uint.Parse(stringNumber.Trim());
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
        badPrivate = true;
        BadSink(data );
    }

    private void BadSink(uint data )
    {
        if (badPrivate)
        {
            /* POTENTIAL FLAW: if data == uint.MinValue, this will overflow */
            uint result = (uint)(data - 1);
            IO.WriteLine("result: " + result);
        }
    }
#endif //omitbad
    /* The variables below are used to drive control flow in the sink functions. */
    private bool goodB2G1Private = false;
    private bool goodB2G2Private = false;
    private bool goodG2BPrivate = false;

}
}
