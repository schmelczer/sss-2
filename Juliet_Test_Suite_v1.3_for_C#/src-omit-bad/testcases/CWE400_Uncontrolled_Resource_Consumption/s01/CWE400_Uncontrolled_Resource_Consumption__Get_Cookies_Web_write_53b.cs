/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE400_Uncontrolled_Resource_Consumption__Get_Cookies_Web_write_53b.cs
Label Definition File: CWE400_Uncontrolled_Resource_Consumption.label.xml
Template File: sources-sinks-53b.tmpl.cs
*/
/*
 * @description
 * CWE: 400 Uncontrolled Resource Consumption
 * BadSource: Get_Cookies_Web Read count from the first cookie using Cookies
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: write
 *    GoodSink: Write to a file count number of times, but first validate count
 *    BadSink : Write to a file count number of times
 * Flow Variant: 53 Data flow: data passed as an argument from one method through two others to a fourth; all four functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;

namespace testcases.CWE400_Uncontrolled_Resource_Consumption
{
class CWE400_Uncontrolled_Resource_Consumption__Get_Cookies_Web_write_53b
{


#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static void GoodG2BSink(int count , HttpRequest req, HttpResponse resp)
    {
        CWE400_Uncontrolled_Resource_Consumption__Get_Cookies_Web_write_53c.GoodG2BSink(count , req, resp);
    }

    /* goodB2G() - use badsource and goodsink */
    public static void GoodB2GSink(int count , HttpRequest req, HttpResponse resp)
    {
        CWE400_Uncontrolled_Resource_Consumption__Get_Cookies_Web_write_53c.GoodB2GSink(count , req, resp);
    }
#endif
}
}
