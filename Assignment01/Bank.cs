using System;
using System.Collections.Generic;
using System.Text;



namespace Assignment01
{
    class Bank
    {

        private string bankName;
        Account[] accounts;


        public Bank(string bankName, int size)
        {
            this.bankName = bankName;
            this.accounts = new Account[size];
        }

        public void AddAccount(Account account)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    accounts[i] = account;
                    break;
                }
            }
        }
        public void DeleteAccount(int accountNo)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i].AccountNumber == accountNo)
                {
                    accounts[i] = null;
                    break;
                }
            }
        }
      public void Transaction()
        {


        }
      
        public void PrintAccountDetails(int accountNo)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    continue;
                }
                if (accounts[i].AccountNumber == accountNo)
                {
                    accounts[i].ShowAccountInformation();
                    break;
                }
                }
            }
        }






    }

