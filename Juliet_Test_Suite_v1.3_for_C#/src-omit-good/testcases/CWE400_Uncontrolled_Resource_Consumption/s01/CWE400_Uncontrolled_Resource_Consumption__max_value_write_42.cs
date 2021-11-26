/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE400_Uncontrolled_Resource_Consumption__max_value_write_42.cs
Label Definition File: CWE400_Uncontrolled_Resource_Consumption.label.xml
Template File: sources-sinks-42.tmpl.cs
*/
/*
 * @description
 * CWE: 400 Uncontrolled Resource Consumption
 * BadSource: max_value Set count to a hardcoded value of Integer.MaxValue
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: write
 *    GoodSink: Write to a file count number of times, but first validate count
 *    BadSink : Write to a file count number of times
 * Flow Variant: 42 Data flow: data returned from one method to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.IO;

using System.Web;

namespace testcases.CWE400_Uncontrolled_Resource_Consumption
{
class CWE400_Uncontrolled_Resource_Consumption__max_value_write_42 : AbstractTestCase
{
#if (!OMITBAD)
    private static int BadSource()
    {
        int count;
        /* POTENTIAL FLAW: Set count to int.MaxValue */
        count = int.MaxValue;
        return count;
    }

    public override void Bad()
    {
        int count = BadSource();
        int i;
        using (StreamWriter file = new StreamWriter(@"badSink.txt"))
        {
            /* POTENTIAL FLAW: Do not validate count before using it as the for loop variant to write to a file */
            for (i = 0; i < count; i++)
            {
                try
                {
                    file.Write("Hello");
                }
                catch (IOException exceptIO)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, "Error with stream writing", exceptIO);
                }
            }
            /* Close stream reading objects */
            try
            {
                if (file != null)
                {
                    file.Close();
                }
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, "Error closing Stream Writer", exceptIO);
            }
        }
    }
#endif //omitbad

}
}
