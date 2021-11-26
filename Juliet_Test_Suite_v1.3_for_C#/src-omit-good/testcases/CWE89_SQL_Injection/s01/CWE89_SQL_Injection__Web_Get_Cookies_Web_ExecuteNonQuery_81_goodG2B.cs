/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE89_SQL_Injection__Web_Get_Cookies_Web_ExecuteNonQuery_81_goodG2B.cs
Label Definition File: CWE89_SQL_Injection__Web.label.xml
Template File: sources-sinks-81_goodG2B.tmpl.cs
*/
/*
 * @description
 * CWE: 89 SQL Injection
 * BadSource: Get_Cookies_Web Read data from the first cookie using Cookies
 * GoodSource: A hardcoded string
 * Sinks: ExecuteNonQuery
 *    GoodSink: Use prepared statement and ExecuteNonQuery (properly)
 *    BadSink : data concatenated into SQL statement used in ExecuteNonQuery(), which could result in SQL Injection
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

