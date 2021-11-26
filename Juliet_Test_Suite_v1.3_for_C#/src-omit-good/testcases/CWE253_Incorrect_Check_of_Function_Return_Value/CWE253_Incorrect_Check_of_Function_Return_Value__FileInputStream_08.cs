/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE253_Incorrect_Check_of_Function_Return_Value__FileInputStream_08.cs
Label Definition File: CWE253_Incorrect_Check_of_Function_Return_Value__FileInputStream.label.xml
Template File: point-flaw-08.tmpl.cs
*/
/*
* @description
* CWE: 253 Incorrect Check of Function Return Value
* Sinks:
*    GoodSink: Check the return value from FileInputStream.read() and handle possible errors
*    BadSink : Check the return value of FileInputStream.read() for the wrong value
* Flow Variant: 08 Control flow: if(PrivateReturnsTrue()) and if(PrivateReturnsFalse())
*
* */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE253_Incorrect_Check_of_Function_Return_Value
{
class CWE253_Incorrect_Check_of_Function_Return_Value__FileInputStream_08 : AbstractTestCase
{
    /* The methods below always return the same value, so a tool
     * should be able to figure out that every call to these
     * methods will return true or return false.
     */
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
        if (PrivateReturnsTrue())
        {
            using (Stream s = new MemoryStream())
            {
                for (int i = 0; i < 122; i++)
                {
                    s.WriteByte((byte)i);
                }
                s.Position = 0;
                try
                {
                    while (true)
                    {
                        // Now read s into a byte buffer with a little padding.
                        byte[] bytes = new byte[s.Length + 10];
                        int numBytesToRead = (int)s.Length;
                        int numBytesRead = 0;
                        int n = s.Read(bytes, numBytesRead, 1);
                        /* FLAW: Incorrect check of return value, which should be 0 for EOF */
                        if (n == -1)
                        {
                            IO.WriteLine("The end of the file has been reached.");
                            break;
                        }
                    }
                    /* INCIDENTAL: CWE561 dead code */
                    s.Close();
                }
                catch (FileNotFoundException exceptFileNotFound)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, "FileNotFoundException opening file", exceptFileNotFound);
                }
                catch (IOException exceptIO)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, "IOException reading file", exceptIO);
                }
            }
        }
    }
#endif //omitbad

}
}
