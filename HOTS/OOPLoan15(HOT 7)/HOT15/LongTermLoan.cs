using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOT15
{
    class LongTermLoan : ILoan
    {
        const double monthlyPayment = 200;
        const double interestRate = .05; 
        double interest = 0;
        double payment = 0;
        string _name;
        string _type;
        double _balance;

        public LongTermLoan(string name, string type, double balance)
        {
            _name = name;
            _type = type;
            _balance = balance;
        }
        public string GetName()
        {
            return _name;
        }
        public new string GetType()
        {
            return _type;
        }
        public double GetBalance()
        {
            return _balance;
        }
        public void MakePayment()
        {
            payment = _balance - monthlyPayment;
        }
        public void ApplyInterest()
        {
            double theInterest = 0;
            interest = payment * interestRate;
            theInterest = interest + payment;

        }
        public string GetLoan(string sep) =>
            _name + sep + _type + sep + _balance.ToString("c");

    }
    
}
