﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlock_P2P
{
    public class Transaction
    {
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        public int Amount { get; set; }

        public Transaction(string fromAddress, string toAddress, int amount)
        {
            FromAddress = fromAddress;
            ToAddress = toAddress;
            Amount = amount;
        }
    }
}