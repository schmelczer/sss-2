/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE643_Xpath_Injection__Params_Get_Web_81_bad.cs
Label Definition File: CWE643_Xpath_Injection.label.xml
Template File: sources-sinks-81_bad.tmpl.cs
*/
/*
 * @description
 * CWE: 643 Xpath Injection
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded string
 * Sinks:
 *    GoodSink: validate input through SecurityElement.Escape
 *    BadSink : user input is used without validate
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

