/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE78_OS_Command_Injection__ReadLine_81_goodG2B.cs
Label Definition File: CWE78_OS_Command_Injection.label.xml
Template File: sources-sink-81_goodG2B.tmpl.cs
*/
/*
 * @description
 * CWE: 78 OS Command Injection
 * BadSource: ReadLine Read data from the console using ReadLine()
 * GoodSource: A hardcoded string
 * Sinks: exec
 *    BadSink : dynamic command execution with Runtime.getRuntime().exec()
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

