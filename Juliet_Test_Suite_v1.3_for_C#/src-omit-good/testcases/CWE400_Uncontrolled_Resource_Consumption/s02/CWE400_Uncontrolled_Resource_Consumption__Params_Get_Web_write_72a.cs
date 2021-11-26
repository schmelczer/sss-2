/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE400_Uncontrolled_Resource_Consumption__Params_Get_Web_write_72a.cs
Label Definition File: CWE400_Uncontrolled_Resource_Consumption.label.xml
Template File: sources-sinks-72a.tmpl.cs
*/
/*
 * @description
 * CWE: 400 Uncontrolled Resource Consumption
 * BadSource: Params_Get_Web Read count from a querystring using Params.Get()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: write
 *    GoodSink: Write to a file count number of times, but first validate count
 *    BadSink : Write to a file count number of times
 * Flow Variant: 72 Data flow: data passed in a Hashtable from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections;
using System;

using System.Web;


namespace testcases.CWE400_Uncontrolled_Resource_Consumption
{
class CWE400_Uncontrolled_Resource_Consumption__Params_Get_Web_write_72a : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        int count;
        count = int.MinValue; /* Initialize count */
        /* POTENTIAL FLAW: Read count from a querystring using Params.Get() */
        {
            string stringNumber = req.Params.Get("name");
            try
            {
                count = int.Parse(stringNumber.Trim());
            }
            catch (FormatException exceptNumberFormat)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Number format exception reading count from parameter 'name'");
            }
        }
        Hashtable countHashtable = new Hashtable(5);
        countHashtable.Add(0, count);
        countHashtable.Add(1, count);
        countHashtable.Add(2, count);
        CWE400_Uncontrolled_Resource_Consumption__Params_Get_Web_write_72b.BadSink(countHashtable , req, resp );
    }
#endif //omitbad

}
}