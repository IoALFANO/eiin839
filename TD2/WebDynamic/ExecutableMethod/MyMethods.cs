using System;

namespace ExternExeCall
{
    class MyMethods
    {
        public static void Main(string[] args)
        {
            {
                if (args.Length == 2)
                    Console.WriteLine("<HTML><BODY> Hello, je suis mymethod et j'utilise CGI-BIN et je vous dis que le paramètre 1 est \"" + args[0] + "\" et que le paramètre 2 est \"" + args[1] + "\"</BODY></HTML>");
                else
                    Console.WriteLine("<HTML><BODY>Hello, je suis mymethod et j'utilise CGI-BIN et je vous dis qu'il n'y a pas assez d'arguments pour vous les énoncer.</BODY></HTML>");
            }
        }
    }
}