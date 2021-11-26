/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE78_OS_Command_Injection__QueryString_Web_81_goodG2B.cs
Label Definition File: CWE78_OS_Command_Injection.label.xml
Template File: sources-sink-81_goodG2B.tmpl.cs
*/
/*
 * @description
 * CWE: 78 OS Command Injection
 * BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
 * GoodSource: A hardcoded string
 * Sinks: exec
 *    BadSink : dynamic command execution with Runtime.getRuntime().exec()
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

