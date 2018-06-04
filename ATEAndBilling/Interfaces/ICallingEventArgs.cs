using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATEAndBilling.Interfaces
{
    public interface ICallingEventArgs
    {
        int TelephoneNumber { get; }
        int TargetTelephoneNumber { get; }
        Guid Id { get; }
    }
}
