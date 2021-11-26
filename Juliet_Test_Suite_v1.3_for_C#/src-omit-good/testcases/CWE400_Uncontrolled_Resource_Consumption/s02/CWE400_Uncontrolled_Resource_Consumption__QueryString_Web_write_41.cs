/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE400_Uncontrolled_Resource_Consumption__QueryString_Web_write_41.cs
Label Definition File: CWE400_Uncontrolled_Resource_Consumption.label.xml
Template File: sources-sinks-41.tmpl.cs
*/
/*
 * @description
 * CWE: 400 Uncontrolled Resource Consumption
 * BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: write
 *    GoodSink: Write to a file count number of times, but first validate count
 *    BadSink : Write to a file count number of times
 * Flow Variant: 41 Data flow: data passed as an argument from one method to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.IO;

using System.Web;


namespace testcases.CWE400_Uncontrolled_Resource_Consumption
{
class CWE400_Uncontrolled_Resource_Consumption__QueryString_Web_write_41 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    private static void BadSink(int count , HttpRequest req, HttpResponse resp)
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

    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        int count;
        count = int.MinValue; /* initialize count in case id is not in query string */
        /* POTENTIAL FLAW: Parse id param out of the URL querystring (without using getParam) */
        {
            if (req.QueryString["id"] != null)
            {
                try
                {
                    count = int.Parse(req.QueryString["id"]);
                }
                catch (FormatException exceptNumberFormat)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Number format exception reading id from query string");
                }
            }
        }
        BadSink(count , req, resp );
    }
#endif //omitbad

}
}
