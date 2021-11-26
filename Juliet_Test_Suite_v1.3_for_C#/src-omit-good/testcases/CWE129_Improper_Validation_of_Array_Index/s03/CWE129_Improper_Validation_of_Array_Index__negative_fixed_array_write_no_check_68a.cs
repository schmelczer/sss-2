/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE129_Improper_Validation_of_Array_Index__negative_fixed_array_write_no_check_68a.cs
Label Definition File: CWE129_Improper_Validation_of_Array_Index.label.xml
Template File: sources-sinks-68a.tmpl.cs
*/
/*
 * @description
 * CWE: 129 Improper Validation of Array Index
 * BadSource: negative_fixed Set data to a negative value
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: array_write_no_check
 *    GoodSink: Write to array after verifying index
 *    BadSink : Write to array without any verification of index
 * Flow Variant: 68 Data flow: data passed as a member variable in the "a" class, which is used by a method in another class in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE129_Improper_Validation_of_Array_Index
{
class CWE129_Improper_Validation_of_Array_Index__negative_fixed_array_write_no_check_68a : AbstractTestCase
{

    public static int data;
#if (!OMITBAD)
    public override void Bad()
    {
        /* POTENTIAL FLAW: Set data to a negative value */
        data = -1;
        CWE129_Improper_Validation_of_Array_Index__negative_fixed_array_write_no_check_68b.BadSink();
    }
#endif //omitbad

}
}
