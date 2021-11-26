/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE89_SQL_Injection__Web_File_ExecuteScalar_73b.cs
Label Definition File: CWE89_SQL_Injection__Web.label.xml
Template File: sources-sinks-73b.tmpl.cs
*/
/*
 * @description
 * CWE: 89 SQL Injection
 * BadSource: File Read data from file (named data.txt)
 * GoodSource: A hardcoded string
 * Sinks: ExecuteScalar
 *    GoodSink: Use prepared statement and ExecuteScalar() (properly)
 *    BadSink : data concatenated into SQL statement used in ExecuteScalar(), which could result in SQL Injection
 * Flow Variant: 73 Data flow: data passed in a LinkedList from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;
using System.Collections.Generic;

using System.Data.SqlClient;
using System.Data;
using System.Web;

namespace testcases.CWE89_SQL_Injection
{
class CWE89_SQL_Injection__Web_File_ExecuteScalar_73b
{
#if (!OMITBAD)
    public static void BadSink(LinkedList<string> dataLinkedList , HttpRequest req, HttpResponse resp)
    {
        string data = dataLinkedList.Last.Value;
        try
        {
            using (SqlConnection dbConnection = IO.GetDBConnection())
            {
                dbConnection.Open();
                using (SqlCommand badSqlCommand = new SqlCommand(null, dbConnection))
                {
                    /* POTENTIAL FLAW: data concatenated into SQL statement used in ExecuteScalar(), which could result in SQL Injection */
                    badSqlCommand.CommandText = "select * from users where name='" +data+"'";
                    object firstCol = badSqlCommand.ExecuteScalar();
                    if (firstCol != null)
                    {
                        IO.WriteLine(firstCol.ToString()); /* Use ResultSet in some way */
                    }
                }
            }
        }
        catch (SqlException exceptSql)
        {
            IO.Logger.Log(NLog.LogLevel.Warn, "Error getting database connection", exceptSql);
        }
    }
#endif


}
}
