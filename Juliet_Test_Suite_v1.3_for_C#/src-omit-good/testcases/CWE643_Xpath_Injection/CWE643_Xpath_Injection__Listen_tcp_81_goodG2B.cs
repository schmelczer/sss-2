/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE643_Xpath_Injection__Listen_tcp_81_goodG2B.cs
Label Definition File: CWE643_Xpath_Injection.label.xml
Template File: sources-sinks-81_goodG2B.tmpl.cs
*/
/*
 * @description
 * CWE: 643 Xpath Injection
 * BadSource: Listen_tcp Read data using a listening tcp connection
 * GoodSource: A hardcoded string
 * Sinks:
 *    GoodSink: validate input through SecurityElement.Escape
 *    BadSink : user input is used without validate
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

