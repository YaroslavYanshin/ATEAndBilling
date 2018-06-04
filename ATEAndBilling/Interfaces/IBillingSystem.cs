using ATEAndBilling.Billing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATEAndBilling.Interfaces
{
    public interface IBillingSystem
    {
        Report GetReport(int telephoneNumber);
    }
}
