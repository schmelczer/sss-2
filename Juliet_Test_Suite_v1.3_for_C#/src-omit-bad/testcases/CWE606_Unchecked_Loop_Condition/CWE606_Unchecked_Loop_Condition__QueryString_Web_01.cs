/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE606_Unchecked_Loop_Condition__QueryString_Web_01.cs
Label Definition File: CWE606_Unchecked_Loop_Condition.label.xml
Template File: sources-sinks-01.tmpl.cs
*/
/*
* @description
* CWE: 606 Unchecked Input for Loop Condition
* BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
* GoodSource: hardcoded int in string form
* Sinks:
*    GoodSink: validate loop variable
*    BadSink : loop variable not validated
* Flow Variant: 01 Baseline
*
* */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE606_Unchecked_Loop_Condition
{
class CWE606_Unchecked_Loop_Condition__QueryString_Web_01 : AbstractTestCaseWeb
{

#if (!OMITGOOD)
    public override void Good(HttpRequest req, HttpResponse resp)
    {
        GoodG2B(req, resp);
        GoodB2G(req, resp);
    }

    /* goodG2B() - use goodsource and badsink */
    private void GoodG2B(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* FIX: Use a hardcoded int as a string */
        data = "5";
        int numberOfLoops;
        try
        {
            numberOfLoops = int.Parse(data);
        }
        catch (FormatException exceptNumberFormat)
        {
            IO.WriteLine("Invalid response. Numeric input expected. Assuming 1.");
            IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Invalid response. Numeric input expected. Assuming 1.");
            numberOfLoops = 1;
        }
        for (int i = 0; i < numberOfLoops; i++)
        {
            /* POTENTIAL FLAW: user supplied input used for loop counter test */
            IO.WriteLine("hello world");
        }
    }

    /* goodB2G() - use badsource and goodsink */
    private void GoodB2G(HttpRequest req, HttpResponse resp)
    {
        string data;
        data = ""; /* initialize data in case id is not in query string */
        /* POTENTIAL FLAW: Parse id param out of the URL querystring (without using getParameter()) */
        {
            if (req.QueryString["id"] != null)
            {
                data = req.QueryString["id"];
            }
        }
        int numberOfLoops;
        try
        {
            numberOfLoops = int.Parse(data);
        }
        catch (FormatException exceptNumberFormat)
        {
            IO.WriteLine("Invalid response. Numeric input expected. Assuming 1.");
            IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Invalid response. Numeric input expected. Assuming 1.");
            numberOfLoops = 1;
        }
        /* FIX: loop number thresholds validated */
        if (numberOfLoops >= 0 && numberOfLoops <= 5)
        {
            for (int i = 0; i < numberOfLoops; i++)
            {
                IO.WriteLine("hello world");
            }
        }
    }
#endif //omitgood
}
}
