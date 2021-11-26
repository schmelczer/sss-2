/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE319_Cleartext_Tx_Sensitive_Info__NetClient_SqlConnection_08.cs
Label Definition File: CWE319_Cleartext_Tx_Sensitive_Info.label.xml
Template File: sources-sinks-08.tmpl.cs
*/
/*
* @description
* CWE: 319 Cleartext Transmission of Sensitive Information
* BadSource: NetClient Read password from a web server with WebClient
* GoodSource: Set password to a hardcoded value (one that was not sent over the network)
* Sinks: SqlConnection
*    GoodSink: Decrypt the password from the source before using it in database connection
*    BadSink : Use password directly from source in database connection
* Flow Variant: 08 Control flow: if(PrivateReturnsTrue()) and if(PrivateReturnsFalse())
*
* */

using TestCaseSupport;
using System;

using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;
using System.Text;

using System.Net;

namespace testcases.CWE319_Cleartext_Tx_Sensitive_Info
{
class CWE319_Cleartext_Tx_Sensitive_Info__NetClient_SqlConnection_08 : AbstractTestCase
{

    /* The methods below always return the same value, so a tool
     * should be able to figure out that every call to these
     * methods will return true or return false. */
    private static bool PrivateReturnsTrue()
    {
        return true;
    }

    private static bool PrivateReturnsFalse()
    {
        return false;
    }
#if (!OMITBAD)
    public override void Bad()
    {
        string password;
        if (PrivateReturnsTrue())
        {
            password = ""; /* init password */
            /* read input from WebClient */
            {
                try
                {
                    using (WebClient client = new WebClient())
                    {
                        using (StreamReader sr = new StreamReader(client.OpenRead("http://www.example.org/")))
                        {
                            /* POTENTIAL FLAW: Read password from a web server with WebClient */
                            /* This will be reading the first "line" of the response body,
                             * which could be very long if there are no newlines in the HTML */
                            password = sr.ReadLine();
                        }
                    }
                }
                catch (IOException exceptIO)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, "Error with stream reading", exceptIO);
                }
            }
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure password is inititialized before the Sink to avoid compiler errors */
            password = null;
        }
        if (PrivateReturnsTrue())
        {
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
    }
#endif //omitbad

}
}
