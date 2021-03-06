/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__int_ReadLine_divide_53c.cs
Label Definition File: CWE369_Divide_by_Zero__int.label.xml
Template File: sources-sinks-53c.tmpl.cs
*/
/*
 * @description
 * CWE: 369 Divide by zero
 * BadSource: ReadLine Read data from the console using ReadLine
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: divide
 *    GoodSink: Check for zero before dividing
 *    BadSink : Dividing by a value that may be zero
 * Flow Variant: 53 Data flow: data passed as an argument from one method through two others to a fourth; all four functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__int_ReadLine_divide_53c
{
#if (!OMITBAD)
    public static void BadSink(int data )
    {
        CWE369_Divide_by_Zero__int_ReadLine_divide_53d.BadSink(data );
    }
#endif


}
}
