/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE90_LDAP_Injection__Environment_81_bad.cs
Label Definition File: CWE90_LDAP_Injection.label.xml
Template File: sources-sink-81_bad.tmpl.cs
*/
/*
 * @description
 * CWE: 90 LDAP Injection
 * BadSource: Environment Read data from an environment variable
 * GoodSource: A hardcoded string
 * Sinks:
 *    BadSink : data concatenated into LDAP search, which could result in LDAP Injection
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

