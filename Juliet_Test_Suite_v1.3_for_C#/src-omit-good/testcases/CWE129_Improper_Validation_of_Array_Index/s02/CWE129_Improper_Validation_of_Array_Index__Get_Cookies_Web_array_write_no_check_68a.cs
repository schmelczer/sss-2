/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE129_Improper_Validation_of_Array_Index__Get_Cookies_Web_array_write_no_check_68a.cs
Label Definition File: CWE129_Improper_Validation_of_Array_Index.label.xml
Template File: sources-sinks-68a.tmpl.cs
*/
/*
 * @description
 * CWE: 129 Improper Validation of Array Index
 * BadSource: Get_Cookies_Web Read data from the first cookie using Cookies
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: array_write_no_check
 *    GoodSink: Write to array after verifying index
 *    BadSink : Write to array without any verification of index
 * Flow Variant: 68 Data flow: data passed as a member variable in the "a" class, which is used by a method in another class in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE129_Improper_Validation_of_Array_Index
{
class CWE129_Improper_Validation_of_Array_Index__Get_Cookies_Web_array_write_no_check_68a : AbstractTestCaseWeb
{

    public static int data;
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
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
        CWE129_Improper_Validation_of_Array_Index__Get_Cookies_Web_array_write_no_check_68b.BadSink(req, resp);
    }
#endif //omitbad

}
}
