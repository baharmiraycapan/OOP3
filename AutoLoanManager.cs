using System;

namespace OOP3;

public class AutoLoanManager:ILoanBaseManager
{
    public void Calculate(){
        System.Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı.");
    }
    public void PreInfo(){
        System.Console.WriteLine("Taşıt Kredisi Bilgileri");
    }

    public string loanName = "Otomobil Kredisi";
    public void PrintLoanAppliedMessage(){
        System.Console.WriteLine("-------------- " +loanName + "ne Başvuru Yaptırdın!! --------------");;
        }

}
