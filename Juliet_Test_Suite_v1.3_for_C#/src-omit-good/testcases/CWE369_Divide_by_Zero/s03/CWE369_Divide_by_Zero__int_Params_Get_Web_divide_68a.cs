/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__int_Params_Get_Web_divide_68a.cs
Label Definition File: CWE369_Divide_by_Zero__int.label.xml
Template File: sources-sinks-68a.tmpl.cs
*/
/*
 * @description
 * CWE: 369 Divide by zero
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: divide
 *    GoodSink: Check for zero before dividing
 *    BadSink : Dividing by a value that may be zero
 * Flow Variant: 68 Data flow: data passed as a member variable in the "a" class, which is used by a method in another class in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__int_Params_Get_Web_divide_68a : AbstractTestCaseWeb
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
        CWE369_Divide_by_Zero__int_Params_Get_Web_divide_68b.BadSink(req, resp);
    }
#endif //omitbad

}
}
