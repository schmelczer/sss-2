/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE209_Information_Leak_Error__StackTrace_Web_14.cs
Label Definition File: CWE209_Information_Leak_Error.label.xml
Template File: point-flaw-14.tmpl.cs
*/
/*
* @description
* CWE: 209 Information exposure through error message
* Sinks: StackTrace_Web
*    GoodSink: Print generic error message to console
*    BadSink : Print stack trace to console
* Flow Variant: 14 Control flow: if(IO.staticFive==5) and if(IO.staticFive!=5)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE209_Information_Leak_Error
{
class CWE209_Information_Leak_Error__StackTrace_Web_14 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        if (IO.staticFive == 5)
        {
            try
            {
                throw new InvalidOperationException();
            }
            catch (InvalidOperationException exceptInvalidOperationException)
            {
                resp.Write(exceptInvalidOperationException.ToString()); /* FLAW: Print stack trace in response on error */
            }
        }
    }
#endif //omitbad

}
}
