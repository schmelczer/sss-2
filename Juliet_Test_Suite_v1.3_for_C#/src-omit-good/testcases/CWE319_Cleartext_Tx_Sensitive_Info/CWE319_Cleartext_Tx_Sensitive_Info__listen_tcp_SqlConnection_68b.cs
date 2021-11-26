/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE319_Cleartext_Tx_Sensitive_Info__listen_tcp_SqlConnection_68b.cs
Label Definition File: CWE319_Cleartext_Tx_Sensitive_Info.label.xml
Template File: sources-sinks-68b.tmpl.cs
*/
/*
 * @description
 * CWE: 319 Cleartext Transmission of Sensitive Information
 * BadSource: listen_tcp Read password using a listening tcp connection
 * GoodSource: Set password to a hardcoded value (one that was not sent over the network)
 * Sinks: SqlConnection
 *    GoodSink: Decrypt the password from the source before using it in database connection
 *    BadSink : Use password directly from source in database connection
 * Flow Variant: 68 Data flow: data passed as a member variable in the "a" class, which is used by a method in another class in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace testcases.CWE319_Cleartext_Tx_Sensitive_Info
{
class CWE319_Cleartext_Tx_Sensitive_Info__listen_tcp_SqlConnection_68b
{
#if (!OMITBAD)
    public static void BadSink()
    {
        string password = CWE319_Cleartext_Tx_Sensitive_Info__listen_tcp_SqlConnection_68a.password;
        try
        {
            /* POTENTIAL FLAW: use password directly in SqlConnection() */
            using (SqlConnection connection = new SqlConnection(@"Data Source=(local);Initial Catalog=CWE256;User ID=" + "sa" + ";Password=" + password))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("select * from test_table", connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        catch (SqlException exceptSql)
        {
            IO.Logger.Log(NLog.LogLevel.Warn, "Error with database connection", exceptSql);
        }
    }
#endif


}
}
