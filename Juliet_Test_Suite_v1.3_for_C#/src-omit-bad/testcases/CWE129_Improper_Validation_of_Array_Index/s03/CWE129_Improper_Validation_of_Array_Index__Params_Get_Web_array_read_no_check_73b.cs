/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE129_Improper_Validation_of_Array_Index__Params_Get_Web_array_read_no_check_73b.cs
Label Definition File: CWE129_Improper_Validation_of_Array_Index.label.xml
Template File: sources-sinks-73b.tmpl.cs
*/
/*
 * @description
 * CWE: 129 Improper Validation of Array Index
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: array_read_no_check
 *    GoodSink: Read from array after verifying index
 *    BadSink : Read from array without any verification of index
 * Flow Variant: 73 Data flow: data passed in a LinkedList from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;
using System.Collections.Generic;

using System.Web;

namespace testcases.CWE129_Improper_Validation_of_Array_Index
{
class CWE129_Improper_Validation_of_Array_Index__Params_Get_Web_array_read_no_check_73b
{


#if (!OMITGOOD)
    /* goodG2B() - use GoodSource and BadSink */
    public static void GoodG2BSink(LinkedList<int> dataLinkedList , HttpRequest req, HttpResponse resp)
    {
        int data = dataLinkedList.Last.Value;
        /* Need to ensure that the array is of size > 3  and < 101 due to the GoodSource and the large_fixed BadSource */
        int[] array = { 0, 1, 2, 3, 4 };
        /* POTENTIAL FLAW: Attempt to read from array at location data, which may be outside the array bounds */
        IO.WriteLine(array[data]);
    }

    /* goodB2G() - use BadSource and GoodSink */
    public static void GoodB2GSink(LinkedList<int> dataLinkedList , HttpRequest req, HttpResponse resp)
    {
        int data = dataLinkedList.Last.Value;
        /* Need to ensure that the array is of size > 3  and < 101 due to the GoodSource and the large_fixed BadSource */
        int[] array = { 0, 1, 2, 3, 4 };
        /* FIX: Verify index before reading from array at location data */
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
