using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class HelloWorld
    {
        public string GetMessage()
        {
            return "Hello World";
        }

        public static void Main(string[] args)
        {
            var hello = new HelloWorld();

            var msg = hello.GetMessage();
            Console.WriteLine(msg);
            Console.ReadLine();
            return;
        }
    }
}
