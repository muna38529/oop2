using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment01
{
    class Account
    {
        private int accountNumber;
        private string accountName;
        private double balance;
        private Address address;
        private static int count = 1;

        public Account()
        {
            this.accountNumber = count;
            count++;
        }

        public Account(string accountName, double balance, Address address) : this()
        {
            this.accountName = accountName;
            this.balance = balance;
            this.address = address;
        }
        public Account(double balance, string accountName, Address address) : this(accountName, balance, address)
        {

        }

        public int AccountNumber
        {
            get { return this.accountNumber; }
        }

        public string AccountName
        {
            set { this.accountName = value; }
            get { return this.accountName; }
        }

        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                Console.WriteLine("Previous Balance : " + this.balance);
                this.balance = this.balance - amount;
                Console.WriteLine("Current Balance : " + this.balance);
            }

        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Console.WriteLine("Previous Balance : " + this.balance);
                this.balance = this.balance + amount;
                Console.WriteLine("Current Balance : " + this.balance);
            }
        }

        public void Transfer(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                this.balance = this.balance - amount;
            }

        }

        public void ShowAccountInformation()
        {
            Console.WriteLine("Account No:{0}\nAccount Name : {1}\nBalance:{2}", this.accountNumber, this.accountName, this.balance);
            Console.WriteLine("Address:" + address.GetAddress());
        }

        ~Account()
        {
            this.balance = 0;
        }
    }
    
   







    }

