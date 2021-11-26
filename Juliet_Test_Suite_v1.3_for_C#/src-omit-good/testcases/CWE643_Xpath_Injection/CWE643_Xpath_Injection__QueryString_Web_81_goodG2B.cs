/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE643_Xpath_Injection__QueryString_Web_81_goodG2B.cs
Label Definition File: CWE643_Xpath_Injection.label.xml
Template File: sources-sinks-81_goodG2B.tmpl.cs
*/
/*
 * @description
 * CWE: 643 Xpath Injection
 * BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
 * GoodSource: A hardcoded string
 * Sinks:
 *    GoodSink: validate input through SecurityElement.Escape
 *    BadSink : user input is used without validate
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

