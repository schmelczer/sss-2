/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE400_Uncontrolled_Resource_Consumption__QueryString_Web_write_74a.cs
Label Definition File: CWE400_Uncontrolled_Resource_Consumption.label.xml
Template File: sources-sinks-74a.tmpl.cs
*/
/*
 * @description
 * CWE: 400 Uncontrolled Resource Consumption
 * BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: write
 *    GoodSink: Write to a file count number of times, but first validate count
 *    BadSink : Write to a file count number of times
 * Flow Variant: 74 Data flow: data passed in a Dictionary from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections.Generic;
using System;

using System.Web;


namespace testcases.CWE400_Uncontrolled_Resource_Consumption
{
class CWE400_Uncontrolled_Resource_Consumption__QueryString_Web_write_74a : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        int count;
        count = int.MinValue; /* initialize count in case id is not in query string */
        /* POTENTIAL FLAW: Parse id param out of the URL querystring (without using getParam) */
        {
            if (req.QueryString["id"] != null)
            {
                try
                {
                    count = int.Parse(req.QueryString["id"]);
                }
                catch (FormatException exceptNumberFormat)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Number format exception reading id from query string");
                }
            }
        }
        Dictionary<int,int> countDictionary = new Dictionary<int,int>();
        countDictionary.Add(0, count);
        countDictionary.Add(1, count);
        countDictionary.Add(2, count);
        CWE400_Uncontrolled_Resource_Consumption__QueryString_Web_write_74b.BadSink(countDictionary , req, resp );
    }
#endif //omitbad

}
}
