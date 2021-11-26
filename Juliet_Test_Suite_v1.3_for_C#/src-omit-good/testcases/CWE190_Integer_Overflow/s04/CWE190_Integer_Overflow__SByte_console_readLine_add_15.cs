/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__SByte_console_readLine_add_15.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-15.tmpl.cs
*/
/*
* @description
* CWE: 190 Integer Overflow
* BadSource: console_readLine Read data from the console using readLine
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: add
*    GoodSink: Ensure there will not be an overflow before adding 1 to data
*    BadSink : Add 1 to data, which can cause an overflow
* Flow Variant: 15 Control flow: switch(6) and switch(7)
*
* */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__SByte_console_readLine_add_15 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        sbyte data;
        switch (6)
        {
        case 6:
            /* init data */
            data = 0;
            /* POTENTIAL FLAW: Read data from console with ReadLine*/
            try
            {
                string stringNumber = Console.ReadLine();
                if (stringNumber != null)
                {
                    data = sbyte.Parse(stringNumber.Trim());
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
            /* POTENTIAL FLAW: if data == sbyte.MaxValue, this will overflow */
            sbyte result = (sbyte)(data + 1);
            IO.WriteLine("result: " + result);
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
