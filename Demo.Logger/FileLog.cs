using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Logger
{
    public class FileLog : ILog
    {
        private string filePath;

        public FileLog(string filePath)
        {
            this.filePath = filePath;
        }

        public  void Log(LogMessage message)
        {
            File.AppendAllText(filePath, $"[{message.Level}] ({message.Namespace}): {message.Content}\n");
        }
    }
}
