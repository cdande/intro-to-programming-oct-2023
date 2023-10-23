﻿namespace Banking.Domain;

public class Account
{
    private decimal _balance = 5000;
    public void Deposit(decimal amountToDeposit)
    {
        _balance += amountToDeposit;
    }

    public decimal GetBalance()
    {
        return _balance;
        //return 5000; "Slimed"
    }

    public void Withdraw(decimal amountToWithdraw)
    {
        _balance -= amountToWithdraw;
    }

}