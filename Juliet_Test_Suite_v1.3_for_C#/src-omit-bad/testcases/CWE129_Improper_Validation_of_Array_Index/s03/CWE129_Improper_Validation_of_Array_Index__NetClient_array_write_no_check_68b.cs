/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE129_Improper_Validation_of_Array_Index__NetClient_array_write_no_check_68b.cs
Label Definition File: CWE129_Improper_Validation_of_Array_Index.label.xml
Template File: sources-sinks-68b.tmpl.cs
*/
/*
 * @description
 * CWE: 129 Improper Validation of Array Index
 * BadSource: NetClient Read data from a web server with WebClient
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: array_write_no_check
 *    GoodSink: Write to array after verifying index
 *    BadSink : Write to array without any verification of index
 * Flow Variant: 68 Data flow: data passed as a member variable in the "a" class, which is used by a method in another class in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE129_Improper_Validation_of_Array_Index
{
class CWE129_Improper_Validation_of_Array_Index__NetClient_array_write_no_check_68b
{


#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static void GoodG2BSink()
    {
        int data = CWE129_Improper_Validation_of_Array_Index__NetClient_array_write_no_check_68a.data;
        /* Need to ensure that the array is of size > 3  and < 101 due to the GoodSource and the large_fixed BadSource */
        int[] array = { 0, 1, 2, 3, 4 };
        /* POTENTIAL FLAW: Attempt to write to array at location data, which may be outside the array bounds */
        array[data] = 42;
        /* Skip reading back data from array since that may be another out of bounds operation */
    }

    /* goodB2G() - use badsource and goodsink */
    public static void GoodB2GSink()
    {
        int data = CWE129_Improper_Validation_of_Array_Index__NetClient_array_write_no_check_68a.data;
        /* Need to ensure that the array is of size > 3  and < 101 due to the GoodSource and the large_fixed BadSource */
        int[] array = { 0, 1, 2, 3, 4 };
        /* FIX: Verify index before writing to array at location data */
        if (data >= 0 && data < array.Length)
        {
            array[data] = 42;
        }
        else
        {
            IO.WriteLine("Array index out of bounds");
        }
    }
#endif
}
}