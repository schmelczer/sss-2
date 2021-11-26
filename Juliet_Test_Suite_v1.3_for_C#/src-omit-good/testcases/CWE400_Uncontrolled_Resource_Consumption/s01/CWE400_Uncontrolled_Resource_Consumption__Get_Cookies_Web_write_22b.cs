/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE400_Uncontrolled_Resource_Consumption__Get_Cookies_Web_write_22b.cs
Label Definition File: CWE400_Uncontrolled_Resource_Consumption.label.xml
Template File: sources-sinks-22b.tmpl.cs
*/
/*
 * @description
 * CWE: 400 Uncontrolled Resource Consumption
 * BadSource: Get_Cookies_Web Read count from the first cookie using Cookies
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: write
 *    GoodSink: Write to a file count number of times, but first validate count
 *    BadSink : Write to a file count number of times
 * Flow Variant: 22 Control flow: Flow controlled by value of a public static variable. Sink functions are in a separate file from sources.
 *
 * */

using TestCaseSupport;
using System;

using System.IO;

using System.Web;

namespace testcases.CWE400_Uncontrolled_Resource_Consumption
{
class CWE400_Uncontrolled_Resource_Consumption__Get_Cookies_Web_write_22b
{
#if (!OMITBAD)
    public static void BadSink(int count , HttpRequest req, HttpResponse resp)
    {
        if (CWE400_Uncontrolled_Resource_Consumption__Get_Cookies_Web_write_22a.badPublicStatic)
        {
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
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure count is inititialized before the Sink to avoid compiler errors */
            count = 0;
        }
    }
#endif


}
}
