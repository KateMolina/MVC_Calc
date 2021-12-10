using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCore.Log
{
    public interface ILog
    {
        public void Log(string info);
    }

    public class FileLog : ILog
    {
        public void Log(string info) => File.AppendAllText("db.log", $"{info} {Environment.NewLine}");     
    }

    public class DebugLog : ILog
    {
        public void Log(string info) => Debug.WriteLine($"{info} {Environment.NewLine}");
    }

    public class VoluntaryLog : ILog
    {
        ILog l;
        public VoluntaryLog(ILog log)
        {
            l = log;
        }

        public void Log(string info)
        {
            l?.Log(info);
        }
    }
}
