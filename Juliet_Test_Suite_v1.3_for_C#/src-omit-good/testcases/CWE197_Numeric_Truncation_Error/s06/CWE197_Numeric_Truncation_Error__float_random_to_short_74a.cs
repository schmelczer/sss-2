/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__float_random_to_short_74a.cs
Label Definition File: CWE197_Numeric_Truncation_Error__float.label.xml
Template File: sources-sink-74a.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: random Set data to a random value
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_short
 *    BadSink : Convert data to a short
 * Flow Variant: 74 Data flow: data passed in a Dictionary from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections.Generic;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{
class CWE197_Numeric_Truncation_Error__float_random_to_short_74a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        float data;
        /* FLAW: Set data to a random value */
        data = (float)(float.MaxValue * 2.0 * (new Random().NextDouble()-0.5));
        Dictionary<int,float> dataDictionary = new Dictionary<int,float>();
        dataDictionary.Add(0, data);
        dataDictionary.Add(1, data);
        dataDictionary.Add(2, data);
        CWE197_Numeric_Truncation_Error__float_random_to_short_74b.BadSink(dataDictionary  );
    }
#endif //omitbad

}
}
