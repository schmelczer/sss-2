/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE129_Improper_Validation_of_Array_Index__large_fixed_array_size_54b.cs
Label Definition File: CWE129_Improper_Validation_of_Array_Index.label.xml
Template File: sources-sinks-54b.tmpl.cs
*/
/*
 * @description
 * CWE: 129 Improper Validation of Array Index
 * BadSource: large_fixed Set data to a value greater than the size of the array
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: array_size
 *    GoodSink: data is used to set the size of the array and it must be greater than 0
 *    BadSink : data is used to set the size of the array, but it could be set to 0
 * Flow Variant: 54 Data flow: data passed as an argument from one method through three others to a fifth; all five functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE129_Improper_Validation_of_Array_Index
{
class CWE129_Improper_Validation_of_Array_Index__large_fixed_array_size_54b
{
#if (!OMITBAD)
    public static void BadSink(int data )
    {
        CWE129_Improper_Validation_of_Array_Index__large_fixed_array_size_54c.BadSink(data );
    }
#endif


}
}