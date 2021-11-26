/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__float_large_to_int_67a.cs
Label Definition File: CWE197_Numeric_Truncation_Error__float.label.xml
Template File: sources-sink-67a.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: large Set data to a number larger than long.MaxValue
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_int
 *    BadSink : Convert data to a int
 * Flow Variant: 67 Data flow: data passed in a class from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__float_large_to_int_67a : AbstractTestCase
{

    public class Container
    {
        public float containerOne;
    }
#if (!OMITBAD)
    public override void Bad()
    {
        float data;
        /* FLAW: Use a number larger than short.MaxValue */
        data = long.MaxValue + 5f;
        Container dataContainer = new Container();
        dataContainer.containerOne = data;
        CWE197_Numeric_Truncation_Error__float_large_to_int_67b.BadSink(dataContainer  );
    }
#endif //omitbad

}
}
