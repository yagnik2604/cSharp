using System;

interface IPayment
{
// ✔ No implementation
// ✔ Only method signature
// ✔ This is the contract
    void pay(double amount);
}

class CreditCardPayment : IPayment
{
    public void pay(double amount)
    {
        Console.WriteLine($"Paid {amount} using credit card");

    }
}

class UpiPayment: IPayment
{
    public void pay(double amount)
    {
        Console.WriteLine($"Paid {amount} using UPI");
    }
}

class Program
{
     static void Main(string[] args)
    {
        IPayment payment;

        payment = new CreditCardPayment();
        payment.pay(2000);

        payment = new UpiPayment();
        payment.pay(500);
    }
}

