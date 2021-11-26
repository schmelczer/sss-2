/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE129_Improper_Validation_of_Array_Index__Params_Get_Web_array_read_no_check_81_goodB2G.cs
Label Definition File: CWE129_Improper_Validation_of_Array_Index.label.xml
Template File: sources-sinks-81_goodB2G.tmpl.cs
*/
/*
 * @description
 * CWE: 129 Improper Validation of Array Index
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: array_read_no_check
 *    GoodSink: Read from array after verifying index
 *    BadSink : Read from array without any verification of index
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

