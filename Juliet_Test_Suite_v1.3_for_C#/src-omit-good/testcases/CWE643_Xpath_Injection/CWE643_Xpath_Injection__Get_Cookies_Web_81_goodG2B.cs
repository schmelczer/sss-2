/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE643_Xpath_Injection__Get_Cookies_Web_81_goodG2B.cs
Label Definition File: CWE643_Xpath_Injection.label.xml
Template File: sources-sinks-81_goodG2B.tmpl.cs
*/
/*
 * @description
 * CWE: 643 Xpath Injection
 * BadSource: Get_Cookies_Web Read data from the first cookie using Cookies
 * GoodSource: A hardcoded string
 * Sinks:
 *    GoodSink: validate input through SecurityElement.Escape
 *    BadSink : user input is used without validate
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

