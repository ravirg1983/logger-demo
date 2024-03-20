using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Logger
{
    public interface ILog
    {
        public void Log(LogMessage message);

    }
}
