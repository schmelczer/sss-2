/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__int_QueryString_Web_divide_41.cs
Label Definition File: CWE369_Divide_by_Zero__int.label.xml
Template File: sources-sinks-41.tmpl.cs
*/
/*
 * @description
 * CWE: 369 Divide by zero
 * BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: divide
 *    GoodSink: Check for zero before dividing
 *    BadSink : Dividing by a value that may be zero
 * Flow Variant: 41 Data flow: data passed as an argument from one method to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__int_QueryString_Web_divide_41 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    private static void BadSink(int data , HttpRequest req, HttpResponse resp)
    {
        /* POTENTIAL FLAW: Zero denominator will cause an issue.  An integer division will
        result in an exception. */
        IO.WriteLine("bad: 100/" + data + " = " + (100 / data) + "\n");
    }

    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        int data;
        data = int.MinValue; /* initialize data in case id is not in query string */
        /* POTENTIAL FLAW: Parse id param out of the URL querystring (without using getParam) */
        {
            if (req.QueryString["id"] != null)
            {
                try
                {
                    data = int.Parse(req.QueryString["id"]);
                }
                catch (FormatException exceptNumberFormat)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Number format exception reading id from query string");
                }
            }
        }
        BadSink(data , req, resp );
    }
#endif //omitbad

}
}
