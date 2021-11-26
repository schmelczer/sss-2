/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE89_SQL_Injection__Web_Get_Cookies_Web_CommandText_81_goodB2G.cs
Label Definition File: CWE89_SQL_Injection__Web.label.xml
Template File: sources-sinks-81_goodB2G.tmpl.cs
*/
/*
 * @description
 * CWE: 89 SQL Injection
 * BadSource: Get_Cookies_Web Read data from the first cookie using Cookies
 * GoodSource: A hardcoded string
 * Sinks: CommandText
 *    GoodSink: Use prepared statement and concatenate CommandText (properly)
 *    BadSink : data concatenated into SQL statement used in CommandText, which could result in SQL Injection
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

