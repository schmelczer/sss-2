/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE400_Uncontrolled_Resource_Consumption__ReadLine_write_71a.cs
Label Definition File: CWE400_Uncontrolled_Resource_Consumption.label.xml
Template File: sources-sinks-71a.tmpl.cs
*/
/*
 * @description
 * CWE: 400 Uncontrolled Resource Consumption
 * BadSource: ReadLine Read count from the console using ReadLine
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: write
 *    GoodSink: Write to a file count number of times, but first validate count
 *    BadSink : Write to a file count number of times
 * Flow Variant: 71 Data flow: data passed as an Object reference argument from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;

namespace testcases.CWE400_Uncontrolled_Resource_Consumption
{
class CWE400_Uncontrolled_Resource_Consumption__ReadLine_write_71a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        int count;
        count = int.MinValue; /* Initialize count */
        {
            /* read user input from console with ReadLine */
            try
            {
                /* POTENTIAL FLAW: Read count from the console using ReadLine */
                string stringNumber = Console.ReadLine();
                if (stringNumber != null) // avoid NPD incidental warnings
                {
                    try
                    {
                        count = int.Parse(stringNumber.Trim());
                    }
                    catch(FormatException exceptNumberFormat)
                    {
                        IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Number format exception parsing count from string");
                    }
                }
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
            }
        }
        CWE400_Uncontrolled_Resource_Consumption__ReadLine_write_71b.BadSink((Object)count  );
    }
#endif //omitbad

}
}
