using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
    public class BankAccount
    {
        private string _accountNumber { get; set; }
        private string _ownerName { get; set; }
        private int _balance { get; set; }

        public BankAccount(string accountNumber, string ownerName)
        {
            _accountNumber = accountNumber;
            _ownerName = ownerName;
            _balance = 0;
        }
        public int Deposit(int amount)
        {
            if(amount > 0)
            {
                _balance += amount;
                Console.WriteLine($"{amount} 입금 완료, 잔액 : {_balance}");
                return _balance;
            }

            else
            {
                Console.WriteLine("입금 금액은 0 보다 커야 합니다.");
                return _balance;
            }
        }
        public int Withdraw(int amount)
        {
            if(amount > 0 && _balance >= amount)
            {
                _balance -= amount;
                Console.WriteLine($"{amount} 출금 완료, 잔액 : {_balance}");
                return _balance;
            }
            else if(_balance <= amount)
            {
                Console.WriteLine("잔액이 부족합니다.");
                return _balance;
            }
            else
            {
                Console.WriteLine("출금 금액은 0보다 커야합니다.");
                return _balance;
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"[계좌 정보] {_accountNumber} ({_ownerName}) - 잔액 : {_balance}원");
        }
    }
}

