/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE606_Unchecked_Loop_Condition__Database_81_bad.cs
Label Definition File: CWE606_Unchecked_Loop_Condition.label.xml
Template File: sources-sinks-81_bad.tmpl.cs
*/
/*
 * @description
 * CWE: 606 Unchecked Input for Loop Condition
 * BadSource: Database Read data from a database
 * GoodSource: hardcoded int in string form
 * Sinks:
 *    GoodSink: validate loop variable
 *    BadSink : loop variable not validated
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

