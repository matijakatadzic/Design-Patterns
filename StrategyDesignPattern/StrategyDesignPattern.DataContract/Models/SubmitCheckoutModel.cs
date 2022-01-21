using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyDesignPattern.DataContract.Models
{
    public class SubmitCheckoutModel
    {
        public SelectedMethodEnum SelectedMethod { get; set; }
        public decimal OrderTotal { get; set; }
    }
}
