/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__int_Random_square_05.cs
Label Definition File: CWE190_Integer_Overflow__int.label.xml
Template File: sources-sinks-05.tmpl.cs
*/
/*
* @description
* CWE: 190 Integer Overflow
* BadSource: Random Set data to a random value
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: square
*    GoodSink: Ensure there will not be an overflow before squaring data
*    BadSink : Square data, which can lead to overflow
* Flow Variant: 05 Control flow: if(privateTrue) and if(privateFalse)
*
* */
using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__int_Random_square_05 : AbstractTestCase
{

    /* The two variables below are not defined as "readonly", but are never
     * assigned any other value, so a tool should be able to identify that
     * reads of these will always return their initialized values.
     */
    private bool privateTrue = true;
    private bool privateFalse = false;
#if (!OMITBAD)
    public override void Bad()
    {
        int data;
        if (privateTrue)
        {
            /* POTENTIAL FLAW: Set data to a random value */
            data = (new Random()).Next();
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0;
        }
        if (privateTrue)
        {
            /* POTENTIAL FLAW: if (data*data) > int.MaxValue, this will overflow */
            int result = (int)(data * data);
            IO.WriteLine("result: " + result);
        }
    }
#endif //omitbad

}
}
