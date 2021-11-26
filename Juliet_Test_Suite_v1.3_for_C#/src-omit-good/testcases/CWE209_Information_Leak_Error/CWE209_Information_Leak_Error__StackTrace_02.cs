/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE209_Information_Leak_Error__StackTrace_02.cs
Label Definition File: CWE209_Information_Leak_Error.label.xml
Template File: point-flaw-02.tmpl.cs
*/
/*
* @description
* CWE: 209 Information exposure through error message
* Sinks: StackTrace
*    GoodSink: Print generic error message to console
*    BadSink : Print stack trace to console
* Flow Variant: 02 Control flow: if(true) and if(false)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE209_Information_Leak_Error
{
class CWE209_Information_Leak_Error__StackTrace_02 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (true)
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
