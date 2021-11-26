/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__int_Random_multiply_45.cs
Label Definition File: CWE190_Integer_Overflow__int.label.xml
Template File: sources-sinks-45.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: Random Set data to a random value
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an overflow before multiplying data by 2
 *    BadSink : If data is positive, multiply by 2, which can cause an overflow
 * Flow Variant: 45 Data flow: data passed as a private class member variable from one function to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__int_Random_multiply_45 : AbstractTestCase
{

    private int dataBad;
    private int dataGoodG2B;
    private int dataGoodB2G;
#if (!OMITBAD)
    private void BadSink()
    {
        int data = dataBad;
        if(data > 0) /* ensure we won't have an underflow */
        {
            /* POTENTIAL FLAW: if (data*2) > int.MaxValue, this will overflow */
            int result = (int)(data * 2);
            IO.WriteLine("result: " + result);
        }
    }

    public override void Bad()
    {
        int data;
        /* POTENTIAL FLAW: Set data to a random value */
        data = (new Random()).Next();
        dataBad = data;
        BadSink();
    }
#endif //omitbad

}
}
