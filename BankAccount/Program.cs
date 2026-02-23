using System;
using BankSystem;


BankAccount account = new BankAccount("123-456-789", "홍길동");

account.ShowInfo();
account.Deposit(50000);
account.Deposit(30000);
account.Withdraw(20000);
account.Withdraw(100000);
account.Deposit(-1000);
account.ShowInfo();
