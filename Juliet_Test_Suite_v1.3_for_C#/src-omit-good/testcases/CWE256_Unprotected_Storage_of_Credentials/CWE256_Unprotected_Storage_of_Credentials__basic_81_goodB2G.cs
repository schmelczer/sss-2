/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE256_Unprotected_Storage_of_Credentials__basic_81_goodB2G.cs
Label Definition File: CWE256_Unprotected_Storage_of_Credentials__basic.label.xml
Template File: sources-sinks-81_goodB2G.tmpl.cs
*/
/*
 * @description
 * CWE: 256 Unprotected Storage of Credentials
 * BadSource:  Read password from a .txt file
 * GoodSource: Read password from a .txt file (from the property named password) and then decrypt it
 * Sinks:
 *    GoodSink: Decrypt password and use decrypted password as password to connect to DB
 *    BadSink : Use password as password to connect to DB
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

