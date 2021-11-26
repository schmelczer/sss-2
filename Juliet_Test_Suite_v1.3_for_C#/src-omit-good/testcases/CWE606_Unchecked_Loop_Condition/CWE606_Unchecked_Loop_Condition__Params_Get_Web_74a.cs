/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE606_Unchecked_Loop_Condition__Params_Get_Web_74a.cs
Label Definition File: CWE606_Unchecked_Loop_Condition.label.xml
Template File: sources-sinks-74a.tmpl.cs
*/
/*
 * @description
 * CWE: 606 Unchecked Input for Loop Condition
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: hardcoded int in string form
 * Sinks:
 *    GoodSink: validate loop variable
 *    BadSink : loop variable not validated
 * Flow Variant: 74 Data flow: data passed in a Dictionary from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections.Generic;
using System;

using System.Web;

namespace testcases.CWE606_Unchecked_Loop_Condition
{
class CWE606_Unchecked_Loop_Condition__Params_Get_Web_74a : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* POTENTIAL FLAW: Read data from a querystring using Params.Get */
        data = req.Params.Get("name");
        Dictionary<int,string> dataDictionary = new Dictionary<int,string>();
        dataDictionary.Add(0, data);
        dataDictionary.Add(1, data);
        dataDictionary.Add(2, data);
        CWE606_Unchecked_Loop_Condition__Params_Get_Web_74b.BadSink(dataDictionary , req, resp );
    }
#endif //omitbad

}
}
