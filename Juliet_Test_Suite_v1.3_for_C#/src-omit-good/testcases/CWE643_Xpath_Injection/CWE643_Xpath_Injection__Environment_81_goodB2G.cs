/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE643_Xpath_Injection__Environment_81_goodB2G.cs
Label Definition File: CWE643_Xpath_Injection.label.xml
Template File: sources-sinks-81_goodB2G.tmpl.cs
*/
/*
 * @description
 * CWE: 643 Xpath Injection
 * BadSource: Environment Read data from an environment variable
 * GoodSource: A hardcoded string
 * Sinks:
 *    GoodSink: validate input through SecurityElement.Escape
 *    BadSink : user input is used without validate
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

