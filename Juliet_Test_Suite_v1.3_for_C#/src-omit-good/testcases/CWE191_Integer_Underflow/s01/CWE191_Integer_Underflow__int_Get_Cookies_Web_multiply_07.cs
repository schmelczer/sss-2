/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__int_Get_Cookies_Web_multiply_07.cs
Label Definition File: CWE191_Integer_Underflow__int.label.xml
Template File: sources-sinks-07.tmpl.cs
*/
/*
* @description
* CWE: 191 Integer Underflow
* BadSource: Get_Cookies_Web Read data from the first cookie using Cookies
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: multiply
*    GoodSink: Ensure there will not be an underflow before multiplying data by 2
*    BadSink : If data is negative, multiply by 2, which can cause an underflow
* Flow Variant: 07 Control flow: if(privateFive==5) and if(privateFive!=5)
*
* */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__int_Get_Cookies_Web_multiply_07 : AbstractTestCaseWeb
{

    /* The variable below is not declared "readonly", but is never assigned
     * any other value so a tool should be able to identify that reads of
     * this will always give its initialized value. */
    private int privateFive = 5;
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        int data;
        if (privateFive==5)
        {
            data = int.MinValue; /* initialize data in case there are no cookies */
            /* Read data from cookies */
            {
                HttpCookieCollection cookieSources = req.Cookies;
                if (cookieSources != null)
                {
                    /* POTENTIAL FLAW: Read data from the first cookie value */
                    string stringNumber = cookieSources[0].Value;
                    try
                    {
                        data = int.Parse(stringNumber.Trim());
                    }
                    catch (FormatException exceptNumberFormat)
                    {
                        IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Number format exception reading data from cookie");
                    }
                }
            }
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0;
        }
        if (privateFive==5)
        {
            if(data < 0) /* ensure we won't have an overflow */
            {
                /* POTENTIAL FLAW: if (data * 2) < int.MinValue, this will underflow */
                int result = (int)(data * 2);
                IO.WriteLine("result: " + result);
            }
        }
    }
#endif //omitbad

}
}
