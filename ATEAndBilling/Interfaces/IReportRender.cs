using ATEAndBilling.Billing;
using ATEAndBilling.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATEAndBilling.Interfaces
{
    interface IReportRender
    {
        void Render(Report report);
        IEnumerable<ReportRecord> SortCalls(Report report, TypeSort sortType);
    }
}
