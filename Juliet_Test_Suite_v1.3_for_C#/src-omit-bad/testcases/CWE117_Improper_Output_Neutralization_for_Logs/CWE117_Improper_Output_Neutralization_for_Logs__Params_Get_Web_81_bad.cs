/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE117_Improper_Output_Neutralization_for_Logs__Params_Get_Web_81_bad.cs
Label Definition File: CWE117_Improper_Output_Neutralization_for_Logs.label.xml
Template File: sources-sinks-81_bad.tmpl.cs
*/
/*
 * @description
 * CWE: 117 Improper Output Neutralization for Logs
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded string
 * Sinks: readFile
 *    GoodSink: Logging output is neutralized
 *    BadSink : Logging output is not neutralized
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

