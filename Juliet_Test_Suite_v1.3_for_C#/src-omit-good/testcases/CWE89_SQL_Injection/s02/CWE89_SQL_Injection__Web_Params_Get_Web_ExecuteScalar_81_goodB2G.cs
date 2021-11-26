/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE89_SQL_Injection__Web_Params_Get_Web_ExecuteScalar_81_goodB2G.cs
Label Definition File: CWE89_SQL_Injection__Web.label.xml
Template File: sources-sinks-81_goodB2G.tmpl.cs
*/
/*
 * @description
 * CWE: 89 SQL Injection
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded string
 * Sinks: ExecuteScalar
 *    GoodSink: Use prepared statement and ExecuteScalar() (properly)
 *    BadSink : data concatenated into SQL statement used in ExecuteScalar(), which could result in SQL Injection
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

