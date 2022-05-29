using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegisterSoftware
{
    public class GlobalVariables
    {
        public static CashRegister nextCashRegister = new CashRegister();
        public static Report nextReport = new Report();
        public static Maintainance nextMaintainance = new Maintainance();
    }
}
