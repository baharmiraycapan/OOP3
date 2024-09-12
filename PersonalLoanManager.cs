using System;

namespace OOP3;

public class PersonalLoanManager : ILoanBaseManager
{
    public void Calculate()
    {
        System.Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı.");
        //throw new NotImplementedException();
    }
    public void PreInfo(){
        System.Console.WriteLine("İhtiyaç Kredisi Bilgileri");
    }

    public string loanName = "İhtiyaç Kredisi";
    public void PrintLoanAppliedMessage(){
        System.Console.WriteLine("-------------- " + loanName + "ne Başvuru Yaptırdın!! --------------");
        }
}