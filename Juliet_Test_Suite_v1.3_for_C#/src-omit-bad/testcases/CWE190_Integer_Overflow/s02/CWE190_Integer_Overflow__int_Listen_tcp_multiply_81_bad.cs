/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__int_Listen_tcp_multiply_81_bad.cs
Label Definition File: CWE190_Integer_Overflow__int.label.xml
Template File: sources-sinks-81_bad.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: Listen_tcp Read data using a listening tcp connection
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an overflow before multiplying data by 2
 *    BadSink : If data is positive, multiply by 2, which can cause an overflow
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

