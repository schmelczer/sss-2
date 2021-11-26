/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__int_Database_sub_61a.cs
Label Definition File: CWE191_Integer_Underflow__int.label.xml
Template File: sources-sinks-61a.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: Database Read data from a database
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: sub
 *    GoodSink: Ensure there will not be an underflow before subtracting 1 from data
 *    BadSink : Subtract 1 from data, which can cause an Underflow
 * Flow Variant: 61 Data flow: data returned from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__int_Database_sub_61a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        int data = CWE191_Integer_Underflow__int_Database_sub_61b.BadSource();
        /* POTENTIAL FLAW: if data == int.MinValue, this will overflow */
        int result = (int)(data - 1);
        IO.WriteLine("result: " + result);
    }
#endif //omitbad

}
}