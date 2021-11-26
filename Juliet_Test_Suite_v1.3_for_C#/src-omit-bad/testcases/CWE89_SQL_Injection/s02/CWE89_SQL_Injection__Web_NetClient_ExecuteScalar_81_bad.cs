/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE89_SQL_Injection__Web_NetClient_ExecuteScalar_81_bad.cs
Label Definition File: CWE89_SQL_Injection__Web.label.xml
Template File: sources-sinks-81_bad.tmpl.cs
*/
/*
 * @description
 * CWE: 89 SQL Injection
 * BadSource: NetClient Read data from a web server with WebClient
 * GoodSource: A hardcoded string
 * Sinks: ExecuteScalar
 *    GoodSink: Use prepared statement and ExecuteScalar() (properly)
 *    BadSink : data concatenated into SQL statement used in ExecuteScalar(), which could result in SQL Injection
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

