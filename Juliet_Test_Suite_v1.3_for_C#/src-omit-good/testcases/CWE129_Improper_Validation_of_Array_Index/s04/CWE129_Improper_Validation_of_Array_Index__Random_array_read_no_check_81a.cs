/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE129_Improper_Validation_of_Array_Index__Random_array_read_no_check_81a.cs
Label Definition File: CWE129_Improper_Validation_of_Array_Index.label.xml
Template File: sources-sinks-81a.tmpl.cs
*/
/*
 * @description
 * CWE: 129 Improper Validation of Array Index
 * BadSource: Random Set data to a random value
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: array_read_no_check
 *    GoodSink: Read from array after verifying index
 *    BadSink : Read from array without any verification of index
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE129_Improper_Validation_of_Array_Index
{
class CWE129_Improper_Validation_of_Array_Index__Random_array_read_no_check_81a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        int data;
        /* POTENTIAL FLAW: Set data to a random value */
        data = (new Random()).Next();
        CWE129_Improper_Validation_of_Array_Index__Random_array_read_no_check_81_base baseObject = new CWE129_Improper_Validation_of_Array_Index__Random_array_read_no_check_81_bad();
        baseObject.Action(data );
    }
#endif //omitbad

}
}
