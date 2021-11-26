/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE129_Improper_Validation_of_Array_Index__QueryString_Web_array_read_check_min_67a.cs
Label Definition File: CWE129_Improper_Validation_of_Array_Index.label.xml
Template File: sources-sinks-67a.tmpl.cs
*/
/*
 * @description
 * CWE: 129 Improper Validation of Array Index
 * BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: array_read_check_min
 *    GoodSink: Read from array after verifying that data is at least 0 and less than array.length
 *    BadSink : Read from array after verifying that data is at least 0 (but not verifying that data less than array.length)
 * Flow Variant: 67 Data flow: data passed in a class from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE129_Improper_Validation_of_Array_Index
{
class CWE129_Improper_Validation_of_Array_Index__QueryString_Web_array_read_check_min_67a : AbstractTestCaseWeb
{

    public class Container
    {
        public int containerOne;
    }
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        int data;
        data = int.MinValue; /* initialize data in case id is not in query string */
        /* POTENTIAL FLAW: Parse id param out of the URL querystring (without using getParam) */
        {
            if (req.QueryString["id"] != null)
            {
                try
                {
                    data = int.Parse(req.QueryString["id"]);
                }
                catch (FormatException exceptNumberFormat)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Number format exception reading id from query string");
                }
            }
        }
        Container dataContainer = new Container();
        dataContainer.containerOne = data;
        CWE129_Improper_Validation_of_Array_Index__QueryString_Web_array_read_check_min_67b.BadSink(dataContainer , req, resp );
    }
#endif //omitbad

}
}
