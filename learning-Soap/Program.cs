using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_Soap {
    class Program {
        static void Main(string[] args) {
            var http = new TestDecisionLogic.IntegrationSoapClient();
            Console.WriteLine(http.HelloWorld());
            Console.WriteLine(http.HelloWorld_SSLOnly());

            var https = new testHTTPS.IntegrationSoapClient();
            Console.WriteLine(https.HelloWorld_SSLOnly());

            Console.ReadKey();
        }
    }
}
