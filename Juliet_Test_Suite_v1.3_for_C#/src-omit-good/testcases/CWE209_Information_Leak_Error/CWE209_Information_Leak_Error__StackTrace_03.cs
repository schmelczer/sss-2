/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE209_Information_Leak_Error__StackTrace_03.cs
Label Definition File: CWE209_Information_Leak_Error.label.xml
Template File: point-flaw-03.tmpl.cs
*/
/*
* @description
* CWE: 209 Information exposure through error message
* Sinks: StackTrace
*    GoodSink: Print generic error message to console
*    BadSink : Print stack trace to console
* Flow Variant: 03 Control flow: if(5==5) and if(5!=5)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE209_Information_Leak_Error
{
class CWE209_Information_Leak_Error__StackTrace_03 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (5 == 5)
        {
            try
            {
                throw new InvalidOperationException();
            }
            catch (InvalidOperationException exceptInvalidOperationException)
            {
                IO.WriteLine(exceptInvalidOperationException.ToString()); /* FLAW: Print stack trace to console on error */
            }
        }
    }
#endif //omitbad

}
}
