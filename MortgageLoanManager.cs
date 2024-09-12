using System;

namespace OOP3;

public class MortgageLoanManager : ILoanBaseManager
{
    public void Calculate()
    {
        System.Console.WriteLine("Konut kredisi ödeme planı hesaplandı.");
        //throw new NotImplementedException();
    }
    public void PreInfo(){
        System.Console.WriteLine("Konut Kredisi Bilgileri");
    }
    public string loanName = "Konut Kredisi";
    public void PrintLoanAppliedMessage(){
        System.Console.WriteLine("-------------- " + loanName + "ne Başvuru Yaptırdın!! --------------");;
        }
}
