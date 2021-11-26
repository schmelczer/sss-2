/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE129_Improper_Validation_of_Array_Index__Random_array_write_no_check_42.cs
Label Definition File: CWE129_Improper_Validation_of_Array_Index.label.xml
Template File: sources-sinks-42.tmpl.cs
*/
/*
 * @description
 * CWE: 129 Improper Validation of Array Index
 * BadSource: Random Set data to a random value
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: array_write_no_check
 *    GoodSink: Write to array after verifying index
 *    BadSink : Write to array without any verification of index
 * Flow Variant: 42 Data flow: data returned from one method to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE129_Improper_Validation_of_Array_Index
{
class CWE129_Improper_Validation_of_Array_Index__Random_array_write_no_check_42 : AbstractTestCase
{
#if (!OMITBAD)
    private static int BadSource()
    {
        int data;
        /* POTENTIAL FLAW: Set data to a random value */
        data = (new Random()).Next();
        return data;
    }

    public override void Bad()
    {
        int data = BadSource();
        /* Need to ensure that the array is of size > 3  and < 101 due to the GoodSource and the large_fixed BadSource */
        int[] array = { 0, 1, 2, 3, 4 };
        /* POTENTIAL FLAW: Attempt to write to array at location data, which may be outside the array bounds */
        array[data] = 42;
        /* Skip reading back data from array since that may be another out of bounds operation */
    }
#endif //omitbad

}
}
