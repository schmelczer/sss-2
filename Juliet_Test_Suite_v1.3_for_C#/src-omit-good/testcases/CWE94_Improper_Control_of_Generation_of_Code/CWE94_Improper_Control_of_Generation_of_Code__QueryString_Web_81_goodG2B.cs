/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE94_Improper_Control_of_Generation_of_Code__QueryString_Web_81_goodG2B.cs
Label Definition File: CWE94_Improper_Control_of_Generation_of_Code.label.xml
Template File: sources-sinks-81_goodG2B.tmpl.cs
*/
/*
 * @description
 * CWE: 94 Improper Control of Generation of Code
 * BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
 * GoodSource: Set data to an integer represented as a string
 * Sinks:
 *    GoodSink: Validate user input prior to compiling
 *    BadSink : Compile sourceCode containing unvalidated user input
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

