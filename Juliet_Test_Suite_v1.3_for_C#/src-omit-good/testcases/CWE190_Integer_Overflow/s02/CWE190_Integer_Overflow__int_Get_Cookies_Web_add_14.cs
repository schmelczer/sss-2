/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__int_Get_Cookies_Web_add_14.cs
Label Definition File: CWE190_Integer_Overflow__int.label.xml
Template File: sources-sinks-14.tmpl.cs
*/
/*
* @description
* CWE: 190 Integer Overflow
* BadSource: Get_Cookies_Web Read data from the first cookie using Cookies
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: add
*    GoodSink: Ensure there will not be an overflow before adding 1 to data
*    BadSink : Add 1 to data, which can cause an overflow
* Flow Variant: 14 Control flow: if(IO.staticFive==5) and if(IO.staticFive!=5)
*
* */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__int_Get_Cookies_Web_add_14 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        int data;
        if (IO.staticFive==5)
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
        if (IO.staticFive==5)
        {
            /* POTENTIAL FLAW: if data == int.MaxValue, this will overflow */
            int result = (int)(data + 1);
            IO.WriteLine("result: " + result);
        }
    }
#endif //omitbad

}
}
