/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE400_Uncontrolled_Resource_Consumption__Params_Get_Web_for_loop_13.cs
Label Definition File: CWE400_Uncontrolled_Resource_Consumption.label.xml
Template File: sources-sinks-13.tmpl.cs
*/
/*
* @description
* CWE: 400 Uncontrolled Resource Consumption
* BadSource: Params_Get_Web Read count from a querystring using Params.Get()
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: for_loop
*    GoodSink: Validate count before using it as the loop variant in a for loop
*    BadSink : Use count as the loop variant in a for loop
* Flow Variant: 13 Control flow: if(IO.STATIC_READONLY_FIVE==5) and if(IO.STATIC_READONLY_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE400_Uncontrolled_Resource_Consumption
{
class CWE400_Uncontrolled_Resource_Consumption__Params_Get_Web_for_loop_13 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        int count;
        if (IO.STATIC_READONLY_FIVE==5)
        {
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
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure count is inititialized before the Sink to avoid compiler errors */
            count = 0;
        }
        if (IO.STATIC_READONLY_FIVE==5)
        {
            int i = 0;
            /* POTENTIAL FLAW: For loop using count as the loop variant and no validation */
            for (i = 0; i < count; i++)
            {
                IO.WriteLine("Hello");
            }
        }
    }
#endif //omitbad

}
}
