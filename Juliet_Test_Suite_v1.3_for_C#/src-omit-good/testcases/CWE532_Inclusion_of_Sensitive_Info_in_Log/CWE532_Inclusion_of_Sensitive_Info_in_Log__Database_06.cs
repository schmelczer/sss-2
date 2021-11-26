/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE532_Inclusion_of_Sensitive_Info_in_Log__Database_06.cs
Label Definition File: CWE532_Inclusion_of_Sensitive_Info_in_Log__Database.label.xml
Template File: point-flaw-06.tmpl.cs
*/
/*
* @description
* CWE: 534 Inclusion of Sensitive Information in Log Files
* Sinks:
*    GoodSink: log non-sensitive information to the debug log
*    BadSink : Expose the DB connection string (containing user ID and password) to debug log
* Flow Variant: 06 Control flow: if(PRIVATE_CONST_FIVE==5) and if(PRIVATE_CONST_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

using NLog;
using System.Data.SqlClient;

namespace testcases.CWE532_Inclusion_of_Sensitive_Info_in_Log
{
class CWE532_Inclusion_of_Sensitive_Info_in_Log__Database_06 : AbstractTestCase
{
    /* The variable below is declared "const", so a tool should be able
     * to identify that reads of this will always give its initialized
     * value.
     */
    private const int PRIVATE_CONST_FIVE = 5;
#if (!OMITBAD)
    public override void Bad()
    {
        if (PRIVATE_CONST_FIVE == 5)
        {
            Logger logger = LogManager.GetLogger("cwe_testcases_logger");
            string dbConnectionString = @"Data Source=(local);Initial Catalog=CWE256;User ID=sa;Password=P@ssW0rd";
            try
            {
                using (SqlConnection dBConnection = new SqlConnection(dbConnectionString))
                {
                    dBConnection.Open();
                }
            }
            catch (SqlException exceptSql)
            {
                /* FLAW: Expose the DB connection string (containing user ID and password) to debug log */
                logger.Log(LogLevel.Warn, "Error getting database connection: " + dbConnectionString, exceptSql);
            }
        }
    }
#endif //omitbad

}
}
