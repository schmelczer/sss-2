/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE129_Improper_Validation_of_Array_Index__NetClient_array_read_check_min_67b.cs
Label Definition File: CWE129_Improper_Validation_of_Array_Index.label.xml
Template File: sources-sinks-67b.tmpl.cs
*/
/*
 * @description
 * CWE: 129 Improper Validation of Array Index
 * BadSource: NetClient Read data from a web server with WebClient
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: array_read_check_min
 *    GoodSink: Read from array after verifying that data is at least 0 and less than array.length
 *    BadSink : Read from array after verifying that data is at least 0 (but not verifying that data less than array.length)
 * Flow Variant: 67 Data flow: data passed in a class from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE129_Improper_Validation_of_Array_Index
{
class CWE129_Improper_Validation_of_Array_Index__NetClient_array_read_check_min_67b
{


#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static void GoodG2BSink(CWE129_Improper_Validation_of_Array_Index__NetClient_array_read_check_min_67a.Container dataContainer )
    {
        int data = dataContainer.containerOne;
        /* Need to ensure that the array is of size > 3  and < 101 due to the GoodSource and the large_fixed BadSource */
        int[] array = { 0, 1, 2, 3, 4 };
        /* POTENTIAL FLAW: Verify that data >= 0, but don't verify that data < array.Length, so may be attempting to read out of the array bounds */
        if (data >= 0)
        {
            IO.WriteLine(array[data]);
        }
        else
        {
            IO.WriteLine("Array index out of bounds");
        }
    }

    /* goodB2G() - use badsource and goodsink */
    public static void GoodB2GSink(CWE129_Improper_Validation_of_Array_Index__NetClient_array_read_check_min_67a.Container dataContainer )
    {
        int data = dataContainer.containerOne;
        /* Need to ensure that the array is of size > 3  and < 101 due to the GoodSource and the large_fixed BadSource */
        int[] array = { 0, 1, 2, 3, 4 };
        /* FIX: Fully verify data before reading from array at location data */
        if (data >= 0 && data < array.Length)
        {
            IO.WriteLine(array[data]);
        }
        else
        {
            IO.WriteLine("Array index out of bounds");
        }
    }
#endif
}
}
