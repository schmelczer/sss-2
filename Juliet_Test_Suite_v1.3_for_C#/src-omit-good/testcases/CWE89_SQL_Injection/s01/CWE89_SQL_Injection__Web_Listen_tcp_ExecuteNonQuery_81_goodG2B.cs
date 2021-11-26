/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE89_SQL_Injection__Web_Listen_tcp_ExecuteNonQuery_81_goodG2B.cs
Label Definition File: CWE89_SQL_Injection__Web.label.xml
Template File: sources-sinks-81_goodG2B.tmpl.cs
*/
/*
 * @description
 * CWE: 89 SQL Injection
 * BadSource: Listen_tcp Read data using a listening tcp connection
 * GoodSource: A hardcoded string
 * Sinks: ExecuteNonQuery
 *    GoodSink: Use prepared statement and ExecuteNonQuery (properly)
 *    BadSink : data concatenated into SQL statement used in ExecuteNonQuery(), which could result in SQL Injection
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

