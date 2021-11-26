/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__int_Params_Get_Web_modulo_09.cs
Label Definition File: CWE369_Divide_by_Zero__int.label.xml
Template File: sources-sinks-09.tmpl.cs
*/
/*
* @description
* CWE: 369 Divide by zero
* BadSource: Params_Get_Web Read data from a querystring using Params.Get()
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: modulo
*    GoodSink: Check for zero before modulo
*    BadSink : Modulo by a value that may be zero
* Flow Variant: 09 Control flow: if(IO.STATIC_READONLY_TRUE) and if(IO.STATIC_READONLY_FALSE)
*
* */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__int_Params_Get_Web_modulo_09 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        int data;
        if (IO.STATIC_READONLY_TRUE)
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
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0;
        }
        if (IO.STATIC_READONLY_TRUE)
        {
            /* POTENTIAL FLAW: Zero modulus will cause an issue.  An integer division will
            result in an exception.  */
            IO.WriteLine("100%" + data + " = " + (100 % data) + "\n");
        }
    }
#endif //omitbad

}
}
