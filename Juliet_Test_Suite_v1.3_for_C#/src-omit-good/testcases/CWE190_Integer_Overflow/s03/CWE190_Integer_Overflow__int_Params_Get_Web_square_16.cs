/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__int_Params_Get_Web_square_16.cs
Label Definition File: CWE190_Integer_Overflow__int.label.xml
Template File: sources-sinks-16.tmpl.cs
*/
/*
* @description
* CWE: 190 Integer Overflow
* BadSource: Params_Get_Web Read data from a querystring using Params.Get()
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
class CWE190_Integer_Overflow__int_Params_Get_Web_square_16 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        int data;
        while (true)
        {
            data = int.MinValue; /* Initialize data */
            /* POTENTIAL FLAW: Read data from a querystring using Params.Get() */
            {
                string stringNumber = req.Params.Get("name");
                try
                {
                    data = int.Parse(stringNumber.Trim());
                }
                catch (FormatException exceptNumberFormat)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Number format exception reading data from parameter 'name'");
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
