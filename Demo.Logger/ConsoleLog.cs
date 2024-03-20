using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Logger
{
    public class ConsoleLog : ILog
    {
        public void Log(LogMessage message)
        {
            Console.WriteLine($"[{message.Level}] ({message.Namespace}): {message.Content}");
        }
    }
}
