/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE315_Cleartext_Storage_in_Cookie__Web_81_goodG2B.cs
Label Definition File: CWE315_Cleartext_Storage_in_Cookie__Web.label.xml
Template File: sources-sinks-81_goodG2B.tmpl.cs
*/
/*
 * @description
 * CWE: 315 Cleartext storage of data in a cookie
 * BadSource:  Set data to credentials (without hashing or encryption)
 * GoodSource: Set data to a hash of credentials
 * Sinks:
 *    GoodSink: Hash data before storing in cookie
 *    BadSink : Store data directly in cookie
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

