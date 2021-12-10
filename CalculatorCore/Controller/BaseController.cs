using CalculatorCore.Infrastructure;
using CalculatorCore.Log;
using CalculatorCore.Model;
using CalculatorCore.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCore.Controller
{
    public abstract class BaseController
    {
        public virtual IView View { get; set; }
        public virtual IModel Model { get; set; }
        public virtual IConverter Converter { get; set; }

        public abstract void ButtonClick();
    }

    public class LoggerController : BaseController
    {
        BaseController bc;
        ILog log;
        public LoggerController(BaseController bc, ILog log = null)
        {
            this.bc = bc;
            this.log = new VoluntaryLog(log);
        }

        public override void ButtonClick()
        {
            bc.ButtonClick();
            log.Log($"Button click pressed at { DateTime.Now}");
        }
    }
}
