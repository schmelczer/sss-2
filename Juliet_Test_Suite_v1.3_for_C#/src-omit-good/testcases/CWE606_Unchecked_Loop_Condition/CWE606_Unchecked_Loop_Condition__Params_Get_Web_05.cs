/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE606_Unchecked_Loop_Condition__Params_Get_Web_05.cs
Label Definition File: CWE606_Unchecked_Loop_Condition.label.xml
Template File: sources-sinks-05.tmpl.cs
*/
/*
* @description
* CWE: 606 Unchecked Input for Loop Condition
* BadSource: Params_Get_Web Read data from a querystring using Params.Get()
* GoodSource: hardcoded int in string form
* Sinks:
*    GoodSink: validate loop variable
*    BadSink : loop variable not validated
* Flow Variant: 05 Control flow: if(privateTrue) and if(privateFalse)
*
* */
using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE606_Unchecked_Loop_Condition
{
class CWE606_Unchecked_Loop_Condition__Params_Get_Web_05 : AbstractTestCaseWeb
{

    /* The two variables below are not defined as "readonly", but are never
     * assigned any other value, so a tool should be able to identify that
     * reads of these will always return their initialized values.
     */
    private bool privateTrue = true;
    private bool privateFalse = false;
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        if (privateTrue)
        {
            /* POTENTIAL FLAW: Read data from a querystring using Params.Get */
            data = req.Params.Get("name");
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        if (privateTrue)
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
