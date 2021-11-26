/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE89_SQL_Injection__Web_Database_CommandText_81_bad.cs
Label Definition File: CWE89_SQL_Injection__Web.label.xml
Template File: sources-sinks-81_bad.tmpl.cs
*/
/*
 * @description
 * CWE: 89 SQL Injection
 * BadSource: Database Read data from a database
 * GoodSource: A hardcoded string
 * Sinks: CommandText
 *    GoodSink: Use prepared statement and concatenate CommandText (properly)
 *    BadSink : data concatenated into SQL statement used in CommandText, which could result in SQL Injection
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

