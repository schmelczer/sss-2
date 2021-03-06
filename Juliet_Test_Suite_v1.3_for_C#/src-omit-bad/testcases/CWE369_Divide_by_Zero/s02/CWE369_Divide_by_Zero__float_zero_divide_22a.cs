/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__float_zero_divide_22a.cs
Label Definition File: CWE369_Divide_by_Zero__float.label.xml
Template File: sources-sinks-22a.tmpl.cs
*/
/*
 * @description
 * CWE: 369 Divide by zero
 * BadSource: zero Set data to a hardcoded value of zero
 * GoodSource: A hardcoded non-zero number (two)
 * Sinks: divide
 *    GoodSink: Check for zero before dividing
 *    BadSink : Dividing by a value that may be zero
 * Flow Variant: 22 Control flow: Flow controlled by value of a public static variable. Sink functions are in a separate file from sources.
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__float_zero_divide_22a : AbstractTestCase
{

    /* The public static variable below is used to drive control flow in the sink function. */
    public static bool badPublicStatic = false;

    /* The public static variables below are used to drive control flow in the sink functions. */
    public static bool goodB2G1PublicStatic = false;
    public static bool goodB2G2PublicStatic = false;
    public static bool goodG2BPublicStatic = false;
#if (!OMITGOOD)
    public override void Good()
    {
        GoodB2G1();
        GoodB2G2();
        GoodG2B();
    }

    /* goodB2G1() - use badsource and goodsink by setting the static variable to false instead of true */
    private void GoodB2G1()
    {
        float data = 0.0f;
        data = 0.0f; /* POTENTIAL FLAW: data is set to zero */
        goodB2G1PublicStatic = false;
        CWE369_Divide_by_Zero__float_zero_divide_22b.GoodB2G1Sink(data );
    }

    /* goodB2G2() - use badsource and goodsink by reversing the blocks in the if in the sink function */
    private void GoodB2G2()
    {
        float data = 0.0f;
        data = 0.0f; /* POTENTIAL FLAW: data is set to zero */
        goodB2G2PublicStatic = true;
        CWE369_Divide_by_Zero__float_zero_divide_22b.GoodB2G2Sink(data );
    }

    /* goodG2B() - use goodsource and badsink */
    private void GoodG2B()
    {
        float data = 0.0f;
        /* FIX: Use a hardcoded number that won't a divide by zero */
        data = 2.0f;
        goodG2BPublicStatic = true;
        CWE369_Divide_by_Zero__float_zero_divide_22b.GoodG2BSink(data );
    }
#endif //omitgood
}
}
