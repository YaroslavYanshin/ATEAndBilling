using ATEAndBilling.ATE;
using ATEAndBilling.Billing;
using ATEAndBilling.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATEAndBilling.Interfaces
{
    public interface IATE : IStorage<CallInformation>
    {
        Terminal GetNewTerminal(IContract contract);
        IContract RegisterContract(Subscriber subscriber, TariffType type);
        void CallingTo(object sender, ICallingEventArgs e);
    }
}
