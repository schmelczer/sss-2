/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE606_Unchecked_Loop_Condition__Params_Get_Web_54d.cs
Label Definition File: CWE606_Unchecked_Loop_Condition.label.xml
Template File: sources-sinks-54d.tmpl.cs
*/
/*
 * @description
 * CWE: 606 Unchecked Input for Loop Condition
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: hardcoded int in string form
 * Sinks:
 *    GoodSink: validate loop variable
 *    BadSink : loop variable not validated
 * Flow Variant: 54 Data flow: data passed as an argument from one method through three others to a fifth; all five functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE606_Unchecked_Loop_Condition
{
class CWE606_Unchecked_Loop_Condition__Params_Get_Web_54d
{
#if (!OMITBAD)
    public static void BadSink(string data , HttpRequest req, HttpResponse resp)
    {
        CWE606_Unchecked_Loop_Condition__Params_Get_Web_54e.BadSink(data , req, resp);
    }
#endif


}
}