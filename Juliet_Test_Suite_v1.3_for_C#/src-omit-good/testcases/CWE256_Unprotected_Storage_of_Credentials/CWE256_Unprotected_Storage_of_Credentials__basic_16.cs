/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE256_Unprotected_Storage_of_Credentials__basic_16.cs
Label Definition File: CWE256_Unprotected_Storage_of_Credentials__basic.label.xml
Template File: sources-sinks-16.tmpl.cs
*/
/*
* @description
* CWE: 256 Unprotected Storage of Credentials
* BadSource:  Read password from a .txt file
* GoodSource: Read password from a .txt file (from the property named password) and then decrypt it
* Sinks:
*    GoodSink: Decrypt password and use decrypted password as password to connect to DB
*    BadSink : Use password as password to connect to DB
* Flow Variant: 16 Control flow: while(true)
*
* */

using TestCaseSupport;
using System;

using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace testcases.CWE256_Unprotected_Storage_of_Credentials
{
class CWE256_Unprotected_Storage_of_Credentials__basic_16 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string password;
        while (true)
        {
            password = ""; /* init password */
            /* retrieve the password */
            try
            {
                password = Encoding.UTF8.GetString(File.ReadAllBytes("../../../common/strong_password_file.txt"));
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, "Error with file reading", exceptIO);
            }
            /* POTENTIAL FLAW: The raw password read from the .txt file is passed on (without being decrypted) */
            break;
        }
        while (true)
        {
            /* POTENTIAL FLAW: Use password as a password to connect to a DB  (without being decrypted) */
            using (SqlConnection dBConnection = new SqlConnection(@"Data Source=(local);Initial Catalog=CWE256;User ID=" + "sa" + ";Password=" + password))
            {
                try
                {
                    dBConnection.Open();
                }
                catch (SqlException exceptSql)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, "Error with database connection", exceptSql);
                }
            }
            break;
        }
    }
#endif //omitbad

}
}
