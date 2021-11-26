/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE400_Uncontrolled_Resource_Consumption__QueryString_Web_for_loop_42.cs
Label Definition File: CWE400_Uncontrolled_Resource_Consumption.label.xml
Template File: sources-sinks-42.tmpl.cs
*/
/*
 * @description
 * CWE: 400 Uncontrolled Resource Consumption
 * BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: for_loop
 *    GoodSink: Validate count before using it as the loop variant in a for loop
 *    BadSink : Use count as the loop variant in a for loop
 * Flow Variant: 42 Data flow: data returned from one method to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE400_Uncontrolled_Resource_Consumption
{
class CWE400_Uncontrolled_Resource_Consumption__QueryString_Web_for_loop_42 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    private static int BadSource(HttpRequest req, HttpResponse resp)
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
        return count;
    }

    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        int count = BadSource(req, resp);
        int i = 0;
        /* POTENTIAL FLAW: For loop using count as the loop variant and no validation */
        for (i = 0; i < count; i++)
        {
            IO.WriteLine("Hello");
        }
    }
#endif //omitbad

}
}
