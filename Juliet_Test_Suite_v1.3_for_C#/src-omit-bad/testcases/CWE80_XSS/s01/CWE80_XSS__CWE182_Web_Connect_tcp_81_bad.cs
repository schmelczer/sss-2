/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE80_XSS__CWE182_Web_Connect_tcp_81_bad.cs
Label Definition File: CWE80_XSS__CWE182_Web.label.xml
Template File: sources-sink-81_bad.tmpl.cs
*/
/*
 * @description
 * CWE: 80 Cross Site Scripting (XSS)
 * BadSource: Connect_tcp Read data using an outbound tcp connection
 * GoodSource: A hardcoded string
 * Sinks: Web
 *    BadSink : Display of data in web page after using replaceAll() to remove script tags, which will still allow XSS (CWE 182: Collapse of Data into Unsafe Value)
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

