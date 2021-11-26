/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__Short_max_multiply_72a.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-72a.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: max Set data to the max value for short
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an overflow before multiplying data by 2
 *    BadSink : If data is positive, multiply by 2, which can cause an overflow
 * Flow Variant: 72 Data flow: data passed in a Hashtable from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections;
using System;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__Short_max_multiply_72a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        short data;
        /* POTENTIAL FLAW: Use the maximum size of the data type */
        data = short.MaxValue;
        Hashtable dataHashtable = new Hashtable(5);
        dataHashtable.Add(0, data);
        dataHashtable.Add(1, data);
        dataHashtable.Add(2, data);
        CWE190_Integer_Overflow__Short_max_multiply_72b.BadSink(dataHashtable  );
    }
#endif //omitbad

}
}
