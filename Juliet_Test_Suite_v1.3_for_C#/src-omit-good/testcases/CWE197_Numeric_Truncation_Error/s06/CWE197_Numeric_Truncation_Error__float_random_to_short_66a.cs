/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__float_random_to_short_66a.cs
Label Definition File: CWE197_Numeric_Truncation_Error__float.label.xml
Template File: sources-sink-66a.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: random Set data to a random value
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_short
 *    BadSink : Convert data to a short
 * Flow Variant: 66 Data flow: data passed in an array from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__float_random_to_short_66a : AbstractTestCase
{
#if (!OMITBAD)
    public override  void Bad()
    {
        float data;
        /* FLAW: Set data to a random value */
        data = (float)(float.MaxValue * 2.0 * (new Random().NextDouble()-0.5));
        float[] dataArray = new float[5];
        dataArray[2] = data;
        CWE197_Numeric_Truncation_Error__float_random_to_short_66b.BadSink(dataArray  );
    }
#endif //omitbad

}
}
