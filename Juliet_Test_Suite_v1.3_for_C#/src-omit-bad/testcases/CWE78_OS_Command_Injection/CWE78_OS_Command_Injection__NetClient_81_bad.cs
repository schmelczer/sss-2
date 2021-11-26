/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE78_OS_Command_Injection__NetClient_81_bad.cs
Label Definition File: CWE78_OS_Command_Injection.label.xml
Template File: sources-sink-81_bad.tmpl.cs
*/
/*
 * @description
 * CWE: 78 OS Command Injection
 * BadSource: NetClient Read data from a web server with WebClient
 * GoodSource: A hardcoded string
 * Sinks: exec
 *    BadSink : dynamic command execution with Runtime.getRuntime().exec()
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

