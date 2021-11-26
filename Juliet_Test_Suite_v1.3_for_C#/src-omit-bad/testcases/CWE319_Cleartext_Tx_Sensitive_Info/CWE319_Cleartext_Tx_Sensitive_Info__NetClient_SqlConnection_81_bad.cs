/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE319_Cleartext_Tx_Sensitive_Info__NetClient_SqlConnection_81_bad.cs
Label Definition File: CWE319_Cleartext_Tx_Sensitive_Info.label.xml
Template File: sources-sinks-81_bad.tmpl.cs
*/
/*
 * @description
 * CWE: 319 Cleartext Transmission of Sensitive Information
 * BadSource: NetClient Read password from a web server with WebClient
 * GoodSource: Set password to a hardcoded value (one that was not sent over the network)
 * Sinks: SqlConnection
 *    GoodSink: Decrypt the password from the source before using it in database connection
 *    BadSink : Use password directly from source in database connection
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

