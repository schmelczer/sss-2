/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__int_Params_Get_Web_add_61a.cs
Label Definition File: CWE190_Integer_Overflow__int.label.xml
Template File: sources-sinks-61a.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: add
 *    GoodSink: Ensure there will not be an overflow before adding 1 to data
 *    BadSink : Add 1 to data, which can cause an overflow
 * Flow Variant: 61 Data flow: data returned from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__int_Params_Get_Web_add_61a : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        int data = CWE190_Integer_Overflow__int_Params_Get_Web_add_61b.BadSource(req, resp);
        /* POTENTIAL FLAW: if data == int.MaxValue, this will overflow */
        int result = (int)(data + 1);
        IO.WriteLine("result: " + result);
    }
#endif //omitbad

}
}
