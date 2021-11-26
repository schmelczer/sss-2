/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE400_Uncontrolled_Resource_Consumption__Environment_write_53a.cs
Label Definition File: CWE400_Uncontrolled_Resource_Consumption.label.xml
Template File: sources-sinks-53a.tmpl.cs
*/
/*
 * @description
 * CWE: 400 Uncontrolled Resource Consumption
 * BadSource: Environment Read count from an environment variable
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: write
 *    GoodSink: Write to a file count number of times, but first validate count
 *    BadSink : Write to a file count number of times
 * Flow Variant: 53 Data flow: data passed as an argument from one method through two others to a fourth; all four functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE400_Uncontrolled_Resource_Consumption
{
class CWE400_Uncontrolled_Resource_Consumption__Environment_write_53a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        int count;
        count = int.MinValue; /* Initialize count */
        /* get environment variable ADD */
        /* POTENTIAL FLAW: Read count from an environment variable */
        {
            string stringNumber = Environment.GetEnvironmentVariable("ADD");
            if (stringNumber != null) // avoid NPD incidental warnings
            {
                try
                {
                    count = int.Parse(stringNumber.Trim());
                }
                catch (FormatException exceptNumberFormat)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Number format exception parsing count from string");
                }
            }
        }
        CWE400_Uncontrolled_Resource_Consumption__Environment_write_53b.BadSink(count );
    }
#endif //omitbad

}
}
