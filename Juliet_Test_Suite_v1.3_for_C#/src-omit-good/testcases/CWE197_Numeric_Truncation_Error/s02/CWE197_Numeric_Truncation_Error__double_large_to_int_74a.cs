/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__double_large_to_int_74a.cs
Label Definition File: CWE197_Numeric_Truncation_Error__double.label.xml
Template File: sources-sink-74a.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: large Set data to a number larger than float.MaxValue
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_int
 *    BadSink : Convert data to a int
 * Flow Variant: 74 Data flow: data passed in a Dictionary from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections.Generic;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{
class CWE197_Numeric_Truncation_Error__double_large_to_int_74a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        double data;
        /* FLAW: Use a number larger than long.MaxValue */
        data = float.MaxValue + 5;
        Dictionary<int,double> dataDictionary = new Dictionary<int,double>();
        dataDictionary.Add(0, data);
        dataDictionary.Add(1, data);
        dataDictionary.Add(2, data);
        CWE197_Numeric_Truncation_Error__double_large_to_int_74b.BadSink(dataDictionary  );
    }
#endif //omitbad

}
}
