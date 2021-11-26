/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE15_External_Control_of_System_or_Configuration_Setting__QueryString_Web_21.cs
Label Definition File: CWE15_External_Control_of_System_or_Configuration_Setting.label.xml
Template File: sources-sink-21.tmpl.cs
*/
/*
 * @description
 * CWE: 15 External Control of System or Configuration Setting
 * BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
 * GoodSource: A hardcoded string
 * Sinks:
 *    BadSink : Set the catalog name with the value of data
 * Flow Variant: 21 Control flow: Flow controlled by value of a private variable. All functions contained in one file.
 *
 * */

using TestCaseSupport;
using System;

using System.Data.SqlClient;

using System.Web;


namespace testcases.CWE15_External_Control_of_System_or_Configuration_Setting
{

class CWE15_External_Control_of_System_or_Configuration_Setting__QueryString_Web_21 : AbstractTestCaseWeb
{

    /* The variable below is used to drive control flow in the source function */
    private bool badPrivate = false;
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        badPrivate = true;
        data = Bad_source(req, resp);
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

    private string Bad_source(HttpRequest req, HttpResponse resp)
    {
        string data;
        if (badPrivate)
        {
            data = ""; /* initialize data in case id is not in query string */
            /* POTENTIAL FLAW: Parse id param out of the URL querystring (without using getParameter()) */
            {
                if (req.QueryString["id"] != null)
                {
                    data = req.QueryString["id"];
                }
            }
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        return data;
    }
#endif //omitbad
    /* The variables below are used to drive control flow in the source functions. */
    private bool goodG2B1_private = false;
    private bool GoodG2B2_private = false;

}
}
