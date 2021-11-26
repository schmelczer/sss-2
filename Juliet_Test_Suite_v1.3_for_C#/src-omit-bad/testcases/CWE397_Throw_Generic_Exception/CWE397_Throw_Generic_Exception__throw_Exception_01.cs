/*
 * @description Throw Generic Exception
 *
 * */

using System;
using System.IO;
using TestCaseSupport;

namespace testcases.CWE397_Throw_Generic_Exception
{
    class CWE397_Throw_Generic_Exception__throw_Exception_01 : AbstractTestCase
    {


#if (!OMITGOOD)
        private void Good1()
        {
            try
            {
                using (StreamReader streamFileInput = new StreamReader("filename.txt"))
				{
					IO.WriteLine("File 'filename.txt' exists");
				}
            }
            catch (FileNotFoundException exception)
            {
                throw exception; /* FIX: Throwing a specific exception */
            }
        }

        public override void Good()
        {
            Good1();
        }
#endif // OMITGOOD
}
}
