/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__double_database_to_int_72a.cs
Label Definition File: CWE197_Numeric_Truncation_Error__double.label.xml
Template File: sources-sink-72a.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: database Read data from a database
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_int
 *    BadSink : Convert data to a int
 * Flow Variant: 72 Data flow: data passed in a Hashtable from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections;
using System;

using System.Data.SqlClient;

namespace testcases.CWE197_Numeric_Truncation_Error
{
class CWE197_Numeric_Truncation_Error__double_database_to_int_72a : AbstractTestCase
{

#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
    }

    /* goodG2B() - use goodsource and badsink */
    private static void GoodG2B()
    {
        double data;
        /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
        data = 2;
        Hashtable dataHashtable = new Hashtable(5);
        dataHashtable.Add(0, data);
        dataHashtable.Add(1, data);
        dataHashtable.Add(2, data);
        CWE197_Numeric_Truncation_Error__double_database_to_int_72b.GoodG2BSink(dataHashtable  );
    }
#endif //omitgood
}
}
