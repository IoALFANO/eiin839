using System.Diagnostics;
using System.IO;

namespace BasicWebServer
{
    class MyMethods
    {

        public static string mymethod(string param1_value, string param2_value)
        {
            return ("<HTML><BODY> Hello, je suis mymethod et je vous dis que le paramètre 1 est \"" + param1_value + "\" et que le paramètre 2 est \"" + param2_value + "\"</BODY></HTML>");
        }
    }
}