/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE606_Unchecked_Loop_Condition__Params_Get_Web_17.cs
Label Definition File: CWE606_Unchecked_Loop_Condition.label.xml
Template File: sources-sinks-17.tmpl.cs
*/
/*
* @description
* CWE: 606 Unchecked Input for Loop Condition
* BadSource: Params_Get_Web Read data from a querystring using Params.Get()
* GoodSource: hardcoded int in string form
* Sinks:
*    GoodSink: validate loop variable
*    BadSink : loop variable not validated
* Flow Variant: 17 Control flow: for loops
*
* */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE606_Unchecked_Loop_Condition
{
class CWE606_Unchecked_Loop_Condition__Params_Get_Web_17 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* We need to have one source outside of a for loop in order
         * to prevent the compiler from generating an error because
         * data is uninitialized
         */
        /* POTENTIAL FLAW: Read data from a querystring using Params.Get */
        data = req.Params.Get("name");
        for (int j = 0; j < 1; j++)
        {
            int numberOfLoops;
            try
            {
                numberOfLoops = int.Parse(data);
            }
            catch (FormatException exceptNumberFormat)
            {
                IO.WriteLine("Invalid response. Numeric input expected. Assuming 1.");
                IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Invalid response. Numeric input expected. Assuming 1.");
                numberOfLoops = 1;
            }
            for (int i = 0; i < numberOfLoops; i++)
            {
                /* POTENTIAL FLAW: user supplied input used for loop counter test */
                IO.WriteLine("hello world");
            }
        }
    }
#endif //omitbad

}
}
