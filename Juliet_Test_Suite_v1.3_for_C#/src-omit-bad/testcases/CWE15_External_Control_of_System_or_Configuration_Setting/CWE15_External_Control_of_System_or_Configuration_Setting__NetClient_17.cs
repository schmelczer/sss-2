/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE15_External_Control_of_System_or_Configuration_Setting__NetClient_17.cs
Label Definition File: CWE15_External_Control_of_System_or_Configuration_Setting.label.xml
Template File: sources-sink-17.tmpl.cs
*/
/*
* @description
* CWE: 15 External Control of System or Configuration Setting
* BadSource: NetClient Read data from a web server with WebClient
* GoodSource: A hardcoded string
* BadSink:  Set the catalog name with the value of data
* Flow Variant: 17 Control flow: for loops
*
* */

using TestCaseSupport;
using System;

using System.Data.SqlClient;

using System.Web;

using System.IO;
using System.Net;

namespace testcases.CWE15_External_Control_of_System_or_Configuration_Setting
{

class CWE15_External_Control_of_System_or_Configuration_Setting__NetClient_17 : AbstractTestCase
{

#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink by reversing the block outside the
     * for statement with the one in the for statement */
    private void GoodG2B()
    {
        string data;
        /* FIX: Use a hardcoded string */
        data = "foo";
        for (int i = 0; i < 1; i++)
        {
            SqlConnection dbConnection = null;
            try
            {
                dbConnection = IO.GetDBConnection();
                /* POTENTIAL FLAW: Set the database user name with the value of data
                 * allowing unauthorized access to a portion of the DB */
                dbConnection.ConnectionString = @"Data Source=" + "" + ";Initial Catalog=" + "" + ";User ID=" + data + ";Password=" + "";
                dbConnection.Open();
            }
            catch (SqlException exceptSql)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptSql, "Error getting database connection");
            }
            finally
            {
                try
                {
                    if (dbConnection != null)
                    {
                        dbConnection.Close();
                    }
                }
                catch (SqlException exceptSql)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptSql, "Error closing Connection");
                }
            }
        }
    }

    public override void Good()
    {
        GoodG2B();
    }
#endif //omitgood
}
}