using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace ConsoleApplication
{
    
    public class HelloWorld
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
         (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    
        public static void Main(string[] args)
        {
            Console.WriteLine(GetMessage());
        }

        public static string GetMessage()
        {
            log.Info("test");
            return "hello world";
        }

    }
}
