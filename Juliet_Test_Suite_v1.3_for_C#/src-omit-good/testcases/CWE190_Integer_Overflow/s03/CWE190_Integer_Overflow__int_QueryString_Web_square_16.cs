/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__int_QueryString_Web_square_16.cs
Label Definition File: CWE190_Integer_Overflow__int.label.xml
Template File: sources-sinks-16.tmpl.cs
*/
/*
* @description
* CWE: 190 Integer Overflow
* BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: square
*    GoodSink: Ensure there will not be an overflow before squaring data
*    BadSink : Square data, which can lead to overflow
* Flow Variant: 16 Control flow: while(true)
*
* */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__int_QueryString_Web_square_16 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        int data;
        while (true)
        {
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
            break;
        }
        while (true)
        {
            /* POTENTIAL FLAW: if (data*data) > int.MaxValue, this will overflow */
            int result = (int)(data * data);
            IO.WriteLine("result: " + result);
            break;
        }
    }
#endif //omitbad

}
}
