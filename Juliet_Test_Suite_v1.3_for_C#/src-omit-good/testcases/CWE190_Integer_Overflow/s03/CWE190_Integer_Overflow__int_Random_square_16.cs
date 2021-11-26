/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__int_Random_square_16.cs
Label Definition File: CWE190_Integer_Overflow__int.label.xml
Template File: sources-sinks-16.tmpl.cs
*/
/*
* @description
* CWE: 190 Integer Overflow
* BadSource: Random Set data to a random value
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: square
*    GoodSink: Ensure there will not be an overflow before squaring data
*    BadSink : Square data, which can lead to overflow
* Flow Variant: 16 Control flow: while(true)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__int_Random_square_16 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        int data;
        while (true)
        {
            /* POTENTIAL FLAW: Set data to a random value */
            data = (new Random()).Next();
            break;
        }
        while (true)
        {
            /* POTENTIAL FLAW: if (data*data) > int.MaxValue, this will overflow */
            int result = (int)(data * data);
            IO.WriteLine("result: " + result);
            break;
        }
    }
#endif //omitbad

}
}
