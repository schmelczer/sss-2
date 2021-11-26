/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__int_Get_Cookies_Web_modulo_06.cs
Label Definition File: CWE369_Divide_by_Zero__int.label.xml
Template File: sources-sinks-06.tmpl.cs
*/
/*
* @description
* CWE: 369 Divide by zero
* BadSource: Get_Cookies_Web Read data from the first cookie using Cookies
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: modulo
*    GoodSink: Check for zero before modulo
*    BadSink : Modulo by a value that may be zero
* Flow Variant: 06 Control flow: if(PRIVATE_CONST_FIVE==5) and if(PRIVATE_CONST_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__int_Get_Cookies_Web_modulo_06 : AbstractTestCaseWeb
{

    /* The variable below is declared "const", so a tool should be able
     * to identify that reads of this will always give its initialized
     * value. */
    private const int PRIVATE_CONST_FIVE = 5;
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        int data;
        if (PRIVATE_CONST_FIVE==5)
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
        if (PRIVATE_CONST_FIVE==5)
        {
            /* POTENTIAL FLAW: Zero modulus will cause an issue.  An integer division will
            result in an exception.  */
            IO.WriteLine("100%" + data + " = " + (100 % data) + "\n");
        }
    }
#endif //omitbad

}
}
