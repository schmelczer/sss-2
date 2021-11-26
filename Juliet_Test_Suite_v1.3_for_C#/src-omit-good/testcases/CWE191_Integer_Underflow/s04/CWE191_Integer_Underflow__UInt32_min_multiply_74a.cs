/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__UInt32_min_multiply_74a.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-74a.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: min Set data to the min value for uint
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an underflow before multiplying data by 2
 *    BadSink : If data is negative, multiply by 2, which can cause an underflow
 * Flow Variant: 74 Data flow: data passed in a Dictionary from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections.Generic;
using System;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__UInt32_min_multiply_74a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        uint data;
        /* POTENTIAL FLAW: Use the minimum size of the data type */
        data = uint.MinValue;
        Dictionary<int,uint> dataDictionary = new Dictionary<int,uint>();
        dataDictionary.Add(0, data);
        dataDictionary.Add(1, data);
        dataDictionary.Add(2, data);
        CWE191_Integer_Underflow__UInt32_min_multiply_74b.BadSink(dataDictionary  );
    }
#endif //omitbad

}
}
