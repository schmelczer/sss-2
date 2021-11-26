/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE319_Cleartext_Tx_Sensitive_Info__send_81_goodG2B.cs
Label Definition File: CWE319_Cleartext_Tx_Sensitive_Info__send.label.xml
Template File: sources-sinks-81_goodG2B.tmpl.cs
*/
/*
 * @description
 * CWE: 319 Cleartext Transmission of Sensitive Information
 * BadSource:  Establish data as a password
 * GoodSource: Use a regular string (non-sensitive string)
 * Sinks:
 *    GoodSink: encrypted_channel
 *    BadSink : unencrypted_channel
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

