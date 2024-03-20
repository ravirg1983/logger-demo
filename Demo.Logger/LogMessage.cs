using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Logger
{
    public class LogMessage
    {
        public string Content { get; set; }
        public LogLevel Level { get; set; }
        public string Namespace { get; set; }
    }
    public enum LogLevel
    {
        FATAL,
        ERROR,
        WARN,
        INFO,
        DEBUG
    }

}
