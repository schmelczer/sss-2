/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE129_Improper_Validation_of_Array_Index__Get_Cookies_Web_array_read_no_check_08.cs
Label Definition File: CWE129_Improper_Validation_of_Array_Index.label.xml
Template File: sources-sinks-08.tmpl.cs
*/
/*
* @description
* CWE: 129 Improper Validation of Array Index
* BadSource: Get_Cookies_Web Read data from the first cookie using Cookies
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: array_read_no_check
*    GoodSink: Read from array after verifying index
*    BadSink : Read from array without any verification of index
* Flow Variant: 08 Control flow: if(PrivateReturnsTrue()) and if(PrivateReturnsFalse())
*
* */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE129_Improper_Validation_of_Array_Index
{
class CWE129_Improper_Validation_of_Array_Index__Get_Cookies_Web_array_read_no_check_08 : AbstractTestCaseWeb
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
        if (PrivateReturnsTrue())
        {
            /* Need to ensure that the array is of size > 3  and < 101 due to the GoodSource and the large_fixed BadSource */
            int[] array = { 0, 1, 2, 3, 4 };
            /* POTENTIAL FLAW: Attempt to read from array at location data, which may be outside the array bounds */
            IO.WriteLine(array[data]);
        }
    }
#endif //omitbad

}
}
