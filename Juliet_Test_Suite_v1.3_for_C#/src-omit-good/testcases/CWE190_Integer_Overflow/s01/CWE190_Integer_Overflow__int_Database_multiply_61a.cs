/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__int_Database_multiply_61a.cs
Label Definition File: CWE190_Integer_Overflow__int.label.xml
Template File: sources-sinks-61a.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: Database Read data from a database
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an overflow before multiplying data by 2
 *    BadSink : If data is positive, multiply by 2, which can cause an overflow
 * Flow Variant: 61 Data flow: data returned from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__int_Database_multiply_61a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        int data = CWE190_Integer_Overflow__int_Database_multiply_61b.BadSource();
        if(data > 0) /* ensure we won't have an underflow */
        {
            /* POTENTIAL FLAW: if (data*2) > int.MaxValue, this will overflow */
            int result = (int)(data * 2);
            IO.WriteLine("result: " + result);
        }
    }
#endif //omitbad

}
}