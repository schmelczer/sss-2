/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__int_min_sub_15.cs
Label Definition File: CWE191_Integer_Underflow__int.label.xml
Template File: sources-sinks-15.tmpl.cs
*/
/*
* @description
* CWE: 191 Integer Underflow
* BadSource: min Set data to the minimum value for int
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: sub
*    GoodSink: Ensure there will not be an underflow before subtracting 1 from data
*    BadSink : Subtract 1 from data, which can cause an Underflow
* Flow Variant: 15 Control flow: switch(6) and switch(7)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__int_min_sub_15 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        int data;
        switch (6)
        {
        case 6:
            /* POTENTIAL FLAW: Use the minimum value for this type */
            data = int.MinValue;
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0;
            break;
        }
        switch (7)
        {
        case 7:
            /* POTENTIAL FLAW: if data == int.MinValue, this will overflow */
            int result = (int)(data - 1);
            IO.WriteLine("result: " + result);
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
            break;
        }
    }
#endif //omitbad

}
}
