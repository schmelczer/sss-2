/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE129_Improper_Validation_of_Array_Index__Random_array_read_no_check_54c.cs
Label Definition File: CWE129_Improper_Validation_of_Array_Index.label.xml
Template File: sources-sinks-54c.tmpl.cs
*/
/*
 * @description
 * CWE: 129 Improper Validation of Array Index
 * BadSource: Random Set data to a random value
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: array_read_no_check
 *    GoodSink: Read from array after verifying index
 *    BadSink : Read from array without any verification of index
 * Flow Variant: 54 Data flow: data passed as an argument from one method through three others to a fifth; all five functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE129_Improper_Validation_of_Array_Index
{
class CWE129_Improper_Validation_of_Array_Index__Random_array_read_no_check_54c
{
#if (!OMITBAD)
    public static void BadSink(int data )
    {
        CWE129_Improper_Validation_of_Array_Index__Random_array_read_no_check_54d.BadSink(data );
    }
#endif


}
}