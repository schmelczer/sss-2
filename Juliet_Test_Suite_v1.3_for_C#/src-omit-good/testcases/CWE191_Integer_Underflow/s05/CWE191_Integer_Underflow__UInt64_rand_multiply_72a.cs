/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__UInt64_rand_multiply_72a.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-72a.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: rand Set data to result of rand()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an underflow before multiplying data by 2
 *    BadSink : If data is negative, multiply by 2, which can cause an underflow
 * Flow Variant: 72 Data flow: data passed in a Hashtable from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections;
using System;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__UInt64_rand_multiply_72a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        ulong data;
        /* POTENTIAL FLAW: Use a random value */
        data = IO.GetRandomULong();
        Hashtable dataHashtable = new Hashtable(5);
        dataHashtable.Add(0, data);
        dataHashtable.Add(1, data);
        dataHashtable.Add(2, data);
        CWE191_Integer_Underflow__UInt64_rand_multiply_72b.BadSink(dataHashtable  );
    }
#endif //omitbad

}
}
