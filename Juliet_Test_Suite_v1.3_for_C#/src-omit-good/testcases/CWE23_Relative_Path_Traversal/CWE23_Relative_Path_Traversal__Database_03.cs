/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE23_Relative_Path_Traversal__Database_03.cs
Label Definition File: CWE23_Relative_Path_Traversal.label.xml
Template File: sources-sink-03.tmpl.cs
*/
/*
* @description
* CWE: 23 Relative Path Traversal
* BadSource: Database Read data from a database
* GoodSource: A hardcoded string
* BadSink: readFile no validation
* Flow Variant: 03 Control flow: if(5==5) and if(5!=5)
*
* */

using TestCaseSupport;
using System;

using System.IO;

using System.Web;

using System.Data.SqlClient;

namespace testcases.CWE23_Relative_Path_Traversal
{

class CWE23_Relative_Path_Traversal__Database_03 : AbstractTestCase
{
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad()
    {
        string data;
        if (5 == 5)
        {
            data = ""; /* Initialize data */
            /* Read data from a database */
            {
                try
                {
                    /* setup the connection */
                    using (SqlConnection connection = IO.GetDBConnection())
                    {
                        connection.Open();
                        /* prepare and execute a (hardcoded) query */
                        using (SqlCommand command = new SqlCommand(null, connection))
                        {
                            command.CommandText = "select name from users where id=0";
                            command.Prepare();
                            using (SqlDataReader dr = command.ExecuteReader())
                            {
                                /* POTENTIAL FLAW: Read data from a database query SqlDataReader */
                                data = dr.GetString(1);
                            }
                        }
                    }
                }
                catch (SqlException exceptSql)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptSql, "Error with SQL statement");
                }
            }
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        int p = (int)Environment.OSVersion.Platform;
        string root;
        if (p == (int)PlatformID.Win32NT || p == (int)PlatformID.Win32Windows || p == (int)PlatformID.Win32S || p == (int)PlatformID.WinCE)
        {
            /* running on Windows */
            root = "C:\\uploads\\";
        }
        else
        {
            /* running on non-Windows */
            root = "/home/user/uploads/";
        }
        if (data != null)
        {
            /* POTENTIAL FLAW: no validation of concatenated value */
            if (File.Exists(root + data))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(root + data))
                    {
                        IO.WriteLine(sr.ReadLine());
                    }
                }
                catch (IOException exceptIO)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
                }
            }
        }
    }
#endif //omitbad

}
}
