/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE400_Uncontrolled_Resource_Consumption__sleep_File_66b.cs
Label Definition File: CWE400_Uncontrolled_Resource_Consumption__sleep.label.xml
Template File: sources-sinks-66b.tmpl.cs
*/
/*
 * @description
 * CWE: 400 Uncontrolled Resource Consumption
 * BadSource: File Read count from file (named c:\data.txt)
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks:
 *    GoodSink: Validate count before using it as a parameter in sleep function
 *    BadSink : Use count as the parameter for sleep withhout checking it's size first
 * Flow Variant: 66 Data flow: data passed in an array from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Threading;

namespace testcases.CWE400_Uncontrolled_Resource_Consumption
{
class CWE400_Uncontrolled_Resource_Consumption__sleep_File_66b
{
#if (!OMITBAD)
    public static void BadSink(int[] countArray )
    {
        int count = countArray[2];
        /* POTENTIAL FLAW: Use count as the input to Thread.Sleep() */
        Thread.Sleep(count);
    }
#endif


}
}
