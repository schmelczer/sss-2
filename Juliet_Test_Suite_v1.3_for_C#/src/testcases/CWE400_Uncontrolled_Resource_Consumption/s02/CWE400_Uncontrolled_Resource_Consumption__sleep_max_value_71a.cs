/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE400_Uncontrolled_Resource_Consumption__sleep_max_value_71a.cs
Label Definition File: CWE400_Uncontrolled_Resource_Consumption__sleep.label.xml
Template File: sources-sinks-71a.tmpl.cs
*/
/*
 * @description
 * CWE: 400 Uncontrolled Resource Consumption
 * BadSource: max_value Set count to a hardcoded value of Integer.MaxValue
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks:
 *    GoodSink: Validate count before using it as a parameter in sleep function
 *    BadSink : Use count as the parameter for sleep withhout checking it's size first
 * Flow Variant: 71 Data flow: data passed as an Object reference argument from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE400_Uncontrolled_Resource_Consumption
{
class CWE400_Uncontrolled_Resource_Consumption__sleep_max_value_71a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        int count;
        /* POTENTIAL FLAW: Set count to Integer.MaxValue */
        count = int.MaxValue;
        CWE400_Uncontrolled_Resource_Consumption__sleep_max_value_71b.BadSink((Object)count  );
    }
#endif //omitbad
#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
        GoodB2G();
    }

    /* goodG2B() - use goodsource and badsink */
    private static void GoodG2B()
    {
        int count;
        /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
        count = 2;
        CWE400_Uncontrolled_Resource_Consumption__sleep_max_value_71b.GoodG2BSink((Object)count  );
    }

    /* goodB2G() - use badsource and goodsink */
    private static void GoodB2G()
    {
        int count;
        /* POTENTIAL FLAW: Set count to Integer.MaxValue */
        count = int.MaxValue;
        CWE400_Uncontrolled_Resource_Consumption__sleep_max_value_71b.GoodB2GSink((Object)count  );
    }
#endif //omitgood
}
}
