/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE129_Improper_Validation_of_Array_Index__negative_fixed_array_read_no_check_16.cs
Label Definition File: CWE129_Improper_Validation_of_Array_Index.label.xml
Template File: sources-sinks-16.tmpl.cs
*/
/*
* @description
* CWE: 129 Improper Validation of Array Index
* BadSource: negative_fixed Set data to a negative value
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: array_read_no_check
*    GoodSink: Read from array after verifying index
*    BadSink : Read from array without any verification of index
* Flow Variant: 16 Control flow: while(true)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE129_Improper_Validation_of_Array_Index
{
class CWE129_Improper_Validation_of_Array_Index__negative_fixed_array_read_no_check_16 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        int data;
        while (true)
        {
            /* POTENTIAL FLAW: Set data to a negative value */
            data = -1;
            break;
        }
        while (true)
        {
            /* Need to ensure that the array is of size > 3  and < 101 due to the GoodSource and the large_fixed BadSource */
            int[] array = { 0, 1, 2, 3, 4 };
            /* POTENTIAL FLAW: Attempt to read from array at location data, which may be outside the array bounds */
            IO.WriteLine(array[data]);
            break;
        }
    }
#endif //omitbad

}
}
