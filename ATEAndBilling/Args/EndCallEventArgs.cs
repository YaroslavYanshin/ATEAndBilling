using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATEAndBilling.Interfaces;
using ATEAndBilling.Enums;

namespace ATEAndBilling.Args
{
    public class EndCallEventArgs
    {
        public Guid Id { get; private set; }
        public int TelephoneNumber { get; private set; }
        public int TargetTelephoneNumber { get; private set; }

        public EndCallEventArgs(Guid id, int number)
        {
            Id = id;
            TelephoneNumber = number;
        }
    }
}
