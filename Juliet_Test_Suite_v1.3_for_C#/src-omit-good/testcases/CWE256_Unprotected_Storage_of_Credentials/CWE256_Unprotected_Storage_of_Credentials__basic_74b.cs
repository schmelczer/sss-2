/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE256_Unprotected_Storage_of_Credentials__basic_74b.cs
Label Definition File: CWE256_Unprotected_Storage_of_Credentials__basic.label.xml
Template File: sources-sinks-74b.tmpl.cs
*/
/*
 * @description
 * CWE: 256 Unprotected Storage of Credentials
 * BadSource:  Read password from a .txt file
 * GoodSource: Read password from a .txt file (from the property named password) and then decrypt it
 * Sinks:
 *    GoodSink: Decrypt password and use decrypted password as password to connect to DB
 *    BadSink : Use password as password to connect to DB
 * Flow Variant: 74 Data flow: data passed in a Dictionary from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;
using System.Collections.Generic;

using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace testcases.CWE256_Unprotected_Storage_of_Credentials
{
class CWE256_Unprotected_Storage_of_Credentials__basic_74b
{
#if (!OMITBAD)
    public static void BadSink(Dictionary<int,string> passwordDictionary )
    {
        string password = passwordDictionary[2];
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
    }
#endif


}
}
