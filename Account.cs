using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC22005Assignment3
{

    public class Account
    {
        //the attributes for the account
        private int balance;
        private int pin;
        private int accountNum;
        private int accessSemaphore = 0;

        public bool tryToLock(int lockerID)
        {
            if (accessSemaphore == 0)
            {
                // true means has managed to lock account
                accessSemaphore = lockerID;
                return true;
            }
            // false means could not access account
            return false;
        }

        public bool tryToUnlock(int lockerID)
        {
            if(lockerID == accessSemaphore)
            {
                accessSemaphore = 0;
                return true;
            }
            return false;
        }

        // a constructor that takes initial values for each of the attributes (balance, pin, accountNumber)
        public Account(int balance, int pin, int accountNum)
        {
            this.balance = balance;
            this.pin = pin;
            this.accountNum = accountNum;
        }

        public Account(Account account)
        {
            this.balance = account.balance;
            this.pin = account.pin;
            this.accountNum = account.accountNum;
        }

        //getter and setter functions for balance
        public int getBalance()
        {
            return balance;
        }
        public void setBalance(int newBalance)
        {
            this.balance = newBalance;
        }

        /*
         *   This funciton allows us to decrement the balance of an account
         *   it perfomes a simple check to ensure the balance is greater tha
         *   the amount being debeted
         *   
         *   reurns:
         *   true if the transactions if possible
         *   false if there are insufficent funds in the account
         */
        public Boolean decrementBalance(int amount)
        {
            if (this.balance > amount)
            {
                balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        /*
         * This funciton check the account pin against the argument passed to it
         *
         * returns:
         * true if they match
         * false if they do not
         */
        public Boolean checkPin(int pinEntered)
        {
            if (pinEntered == pin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int getAccountNum()
        {
            return accountNum;
        }

    }
}
