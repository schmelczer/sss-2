/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE400_Uncontrolled_Resource_Consumption__max_value_write_54d.cs
Label Definition File: CWE400_Uncontrolled_Resource_Consumption.label.xml
Template File: sources-sinks-54d.tmpl.cs
*/
/*
 * @description
 * CWE: 400 Uncontrolled Resource Consumption
 * BadSource: max_value Set count to a hardcoded value of Integer.MaxValue
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: write
 *    GoodSink: Write to a file count number of times, but first validate count
 *    BadSink : Write to a file count number of times
 * Flow Variant: 54 Data flow: data passed as an argument from one method through three others to a fifth; all five functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;

namespace testcases.CWE400_Uncontrolled_Resource_Consumption
{
class CWE400_Uncontrolled_Resource_Consumption__max_value_write_54d
{
#if (!OMITBAD)
    public static void BadSink(int count )
    {
        CWE400_Uncontrolled_Resource_Consumption__max_value_write_54e.BadSink(count );
    }
#endif

#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static void GoodG2BSink(int count )
    {
        CWE400_Uncontrolled_Resource_Consumption__max_value_write_54e.GoodG2BSink(count );
    }

    /* goodB2G() - use badsource and goodsink */
    public static void GoodB2GSink(int count )
    {
        CWE400_Uncontrolled_Resource_Consumption__max_value_write_54e.GoodB2GSink(count );
    }
#endif
}
}
