/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE259_Hard_Coded_Password__SqlConnection_14.cs
Label Definition File: CWE259_Hard_Coded_Password.label.xml
Template File: sources-sink-14.tmpl.cs
*/
/*
* @description
* CWE: 259 Hard Coded Password
* BadSource: hardcodedPassword Set data to a hardcoded string
* GoodSource: Read data from the console using readLine()
* BadSink: SqlConnection data used as password in database connection
* Flow Variant: 14 Control flow: if(IO.staticFive==5) and if(IO.staticFive!=5)
*
* */

using TestCaseSupport;
using System;

using System.Data.SqlClient;

using System.IO;

namespace testcases.CWE259_Hard_Coded_Password
{

class CWE259_Hard_Coded_Password__SqlConnection_14 : AbstractTestCase
{
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad()
    {
        string data;
        if (IO.staticFive == 5)
        {
            /* FLAW: Set data to a hardcoded string */
            data = "7e5tc4s3";
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        if (data != null)
        {
            try
            {
                /* POTENTIAL FLAW: data used as password in database connection */
                using (SqlConnection connection = new SqlConnection(@"Data Source=(local);Initial Catalog=CWE256;User ID=" + "sa" + ";Password=" + data))
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
