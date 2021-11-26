/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__UInt16_max_square_21.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-21.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: max Set data to the max value for ushort
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: square
 *    GoodSink: Ensure there will not be an overflow before squaring data
 *    BadSink : Square data, which can lead to overflow
 * Flow Variant: 21 Control flow: Flow controlled by value of a private variable. All functions contained in one file.
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__UInt16_max_square_21 : AbstractTestCase
{

    /* The variable below is used to drive control flow in the sink function */
    private bool badPrivate = false;
#if (!OMITBAD)
    public override void Bad()
    {
        ushort data;
        /* POTENTIAL FLAW: Use the maximum size of the data type */
        data = ushort.MaxValue;
        badPrivate = true;
        BadSink(data );
    }

    private void BadSink(ushort data )
    {
        if (badPrivate)
        {
            /* POTENTIAL FLAW: if (data*data) > ushort.MaxValue, this will overflow */
            ushort result = (ushort)(data * data);
            IO.WriteLine("result: " + result);
        }
    }
#endif //omitbad
    /* The variables below are used to drive control flow in the sink functions. */
    private bool goodB2G1Private = false;
    private bool goodB2G2Private = false;
    private bool goodG2BPrivate = false;

}
}
