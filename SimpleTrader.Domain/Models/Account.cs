using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTrader.Domain.Models
{
    public class Account : DomainObject
    {
        public User AcoountHolder { get; set; }
        public double Balance { get; set; }
        public IEnumerable<AssetTransactions> AssetTransactions { get; set; }
    }
}
