﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationExercise
{
    public class BankAccount
    {
        public BankAccount()
        {
        }
        private double balance = 0;
        public double Balance
            { get { return balance; } set { balance = value; } }
        public void  Deposit (double amount)
        {
            balance = amount;
        }
        public double Getbalance()
            {
            return $"${balance}";
        }
    }
}
