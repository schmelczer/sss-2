/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE470_Unsafe_Reflection__Web_QueryString_Web_81_goodG2B.cs
Label Definition File: CWE470_Unsafe_Reflection__Web.label.xml
Template File: sources-sink-81_goodG2B.tmpl.cs
*/
/*
 * @description
 * CWE: 470 Use of Externally-Controlled Input to Select Classes or Code ('Unsafe Reflection')
 * BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
 * GoodSource: Set data to a hardcoded class name
 * Sinks:
 *    BadSink : Instantiate class named in data
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

