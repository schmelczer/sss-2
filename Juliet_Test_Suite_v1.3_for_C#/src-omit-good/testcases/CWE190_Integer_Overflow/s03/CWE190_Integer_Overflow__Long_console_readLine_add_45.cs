/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__Long_console_readLine_add_45.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-45.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: console_readLine Read data from the console using readLine
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: add
 *    GoodSink: Ensure there will not be an overflow before adding 1 to data
 *    BadSink : Add 1 to data, which can cause an overflow
 * Flow Variant: 45 Data flow: data passed as a private class member variable from one function to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__Long_console_readLine_add_45 : AbstractTestCase
{

    private long dataBad;
    private long dataGoodG2B;
    private long dataGoodB2G;
#if (!OMITBAD)
    private void BadSink()
    {
        long data = dataBad;
        /* POTENTIAL FLAW: if data == long.MaxValue, this will overflow */
        long result = (long)(data + 1);
        IO.WriteLine("result: " + result);
    }

    public override void Bad()
    {
        long data;
        /* init data */
        data = 0;
        /* POTENTIAL FLAW: Read data from console with ReadLine*/
        try
        {
            string stringNumber = Console.ReadLine();
            if (stringNumber != null)
            {
                data = long.Parse(stringNumber.Trim());
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
        dataBad = data;
        BadSink();
    }
#endif //omitbad

}
}
