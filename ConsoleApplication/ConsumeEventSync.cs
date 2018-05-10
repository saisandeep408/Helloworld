using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ConsoleApplication
{
    public class ConsumeEventSync
    {
        public void Helloworld() //Get Hello World  
        {
            using (var client = new WebClient()) //WebClient  
            {
                client.Headers.Add("Content-Type:application/json"); //Content-Type  
                client.Headers.Add("Accept:application/json");
                var result = client.DownloadString("http://localhost:57268/api/values"); //URI  
                Console.WriteLine(Environment.NewLine + result);
                Console.ReadKey();
            }
        }
    }
}

