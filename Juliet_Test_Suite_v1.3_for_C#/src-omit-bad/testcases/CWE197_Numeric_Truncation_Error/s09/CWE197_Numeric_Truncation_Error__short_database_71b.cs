/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__short_database_71b.cs
Label Definition File: CWE197_Numeric_Truncation_Error__short.label.xml
Template File: sources-sink-71b.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: database Read data from a database
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_byte
 *    BadSink : Convert data to a byte
 * Flow Variant: 71 Data flow: data passed as an Object reference argument from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;

using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{
class CWE197_Numeric_Truncation_Error__short_database_71b
{


#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static void GoodG2BSink(Object dataObject )
    {
        short data = (short)dataObject;
        {
            /* POTENTIAL FLAW: Convert data to a byte, possibly causing a truncation error */
            IO.WriteLine((byte)data);
        }
    }
#endif
}
}
