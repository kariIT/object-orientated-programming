using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BankApp
{
    class Transaction
    {
        public DateTime Timestamp { get; }
        private double _sum;

        public Transaction(DateTime timestamp, double sum)
        {
            Timestamp = timestamp;
            Sum = sum;
        }

        public Transaction(double sum)
        {
            Sum = sum;
        }

        public double Sum { get => _sum; set => _sum = value; }
    }
}
