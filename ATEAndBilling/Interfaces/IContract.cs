using ATEAndBilling.Billing;
using ATEAndBilling.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATEAndBilling.Interfaces
{
    public interface IContract
    {
        Subscriber Subscriber { get; }
        int Number { get; }
        Tariff Tariff { get; }
        bool ChangeTariff(TariffType tariffType);
    }
}
