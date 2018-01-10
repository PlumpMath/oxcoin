﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OxCoin.Models
{
    public class Miner
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid WalletId { get; set; }

        public virtual Wallet Wallet { get; set; }
    }
}
