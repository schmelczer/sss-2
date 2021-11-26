/*
 * @description Improper Resource Shutdown.  Performs some, but not all, necessary resource cleanup (FileReader is not closed properly).
 * 
 * */

using TestCaseSupport;

using System.IO;

namespace testcases.CWE404_Improper_Resource_Shutdown
{

    class CWE404_Improper_Resource_Shutdown__FileReader_01 : AbstractTestCase
    {
#if (!OMITBAD)
        /* uses badsource and badsink */
        public override void Bad()
        {
            StreamReader sr = null;

            try
            {
                sr = new StreamReader("C:\\file.txt");
                string readString = sr.ReadLine();

                IO.WriteLine(readString);

                /* FLAW: Attempts to close the streams should be in a finally block. */
                try
                {
                    if (sr != null)
                    {
                        sr.Close();
                    }
                }
                catch (IOException exceptIO)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, "Error closing StreamReader", exceptIO);
                }
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, "Error with stream reading", exceptIO);
            }
        }
#endif // OMITBAD

}
}
