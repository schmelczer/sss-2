/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE606_Unchecked_Loop_Condition__Params_Get_Web_68a.cs
Label Definition File: CWE606_Unchecked_Loop_Condition.label.xml
Template File: sources-sinks-68a.tmpl.cs
*/
/*
 * @description
 * CWE: 606 Unchecked Input for Loop Condition
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: hardcoded int in string form
 * Sinks:
 *    GoodSink: validate loop variable
 *    BadSink : loop variable not validated
 * Flow Variant: 68 Data flow: data passed as a member variable in the "a" class, which is used by a method in another class in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE606_Unchecked_Loop_Condition
{
class CWE606_Unchecked_Loop_Condition__Params_Get_Web_68a : AbstractTestCaseWeb
{

    public static string data;
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        /* POTENTIAL FLAW: Read data from a querystring using Params.Get */
        data = req.Params.Get("name");
        CWE606_Unchecked_Loop_Condition__Params_Get_Web_68b.BadSink(req, resp);
    }
#endif //omitbad

}
}
