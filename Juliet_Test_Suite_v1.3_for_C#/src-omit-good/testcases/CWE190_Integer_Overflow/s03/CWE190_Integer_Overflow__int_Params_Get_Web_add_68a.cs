/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__int_Params_Get_Web_add_68a.cs
Label Definition File: CWE190_Integer_Overflow__int.label.xml
Template File: sources-sinks-68a.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: add
 *    GoodSink: Ensure there will not be an overflow before adding 1 to data
 *    BadSink : Add 1 to data, which can cause an overflow
 * Flow Variant: 68 Data flow: data passed as a member variable in the "a" class, which is used by a method in another class in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__int_Params_Get_Web_add_68a : AbstractTestCaseWeb
{

    public static int data;
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
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
        CWE190_Integer_Overflow__int_Params_Get_Web_add_68b.BadSink(req, resp);
    }
#endif //omitbad

}
}
