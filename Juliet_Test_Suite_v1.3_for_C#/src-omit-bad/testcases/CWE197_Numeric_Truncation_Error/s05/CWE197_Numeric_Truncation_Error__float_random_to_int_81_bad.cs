/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__float_random_to_int_81_bad.cs
Label Definition File: CWE197_Numeric_Truncation_Error__float.label.xml
Template File: sources-sink-81_bad.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: random Set data to a random value
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_int
 *    BadSink : Convert data to a int
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */
