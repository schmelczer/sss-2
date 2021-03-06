/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE252_Unchecked_Return_Value__MemoryStream_16.cs
Label Definition File: CWE252_Unchecked_Return_Value__MemoryStream.label.xml
Template File: point-flaw-16.tmpl.cs
*/
/*
* @description
* CWE: 252 Unchecked Return Value
* Sinks:
*    GoodSink: Check the return value from MemoryStream.Read()
*    BadSink : Do not check the return value of MemoryStream.Read()
* Flow Variant: 16 Control flow: while(true)
*
* */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE252_Unchecked_Return_Value
{
class CWE252_Unchecked_Return_Value__MemoryStream_16 : AbstractTestCase
{

#if (!OMITGOOD)
    /* Good1() change the conditions on the while statements */
    private void Good1()
    {
        while(true)
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
                        /* FIX: Check the return value of read() for EOF */
                        if (n == 0)
                        {
                            IO.WriteLine("The end of the file has been reached.");
                            break;
                        }
                    }
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
            break;
        }
    }

    public override void Good()
    {
        Good1();
    }
#endif //omitgood
}
}
