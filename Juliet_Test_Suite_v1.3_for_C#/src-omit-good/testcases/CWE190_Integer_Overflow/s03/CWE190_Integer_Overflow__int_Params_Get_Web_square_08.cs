/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__int_Params_Get_Web_square_08.cs
Label Definition File: CWE190_Integer_Overflow__int.label.xml
Template File: sources-sinks-08.tmpl.cs
*/
/*
* @description
* CWE: 190 Integer Overflow
* BadSource: Params_Get_Web Read data from a querystring using Params.Get()
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: square
*    GoodSink: Ensure there will not be an overflow before squaring data
*    BadSink : Square data, which can lead to overflow
* Flow Variant: 08 Control flow: if(PrivateReturnsTrue()) and if(PrivateReturnsFalse())
*
* */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__int_Params_Get_Web_square_08 : AbstractTestCaseWeb
{

    /* The methods below always return the same value, so a tool
     * should be able to figure out that every call to these
     * methods will return true or return false. */
    private static bool PrivateReturnsTrue()
    {
        return true;
    }

    private static bool PrivateReturnsFalse()
    {
        return false;
    }
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        int data;
        if (PrivateReturnsTrue())
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
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0;
        }
        if (PrivateReturnsTrue())
        {
            /* POTENTIAL FLAW: if (data*data) > int.MaxValue, this will overflow */
            int result = (int)(data * data);
            IO.WriteLine("result: " + result);
        }
    }
#endif //omitbad

}
}
