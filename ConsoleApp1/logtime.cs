using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Logo
{
    class logtime 
    {

        public static void Logs()
        {
            string txtq = "logtime1.txt";
            string b = "\n" + Convert.ToString(DateTime.Now);
            File.AppendAllText(txtq, b);

          
        }
    }
}
