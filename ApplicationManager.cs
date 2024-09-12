using System;

namespace OOP3;

public class ApplicationManager
{
    public void Apply(ILoanBaseManager loanBaseManager, List<ILoggerService> loggerServices){
        // Loan applicant evaluation
        loanBaseManager.Calculate();
        foreach(var logger in loggerServices){
            logger.Log();
            }
        //System.Console.WriteLine( "Otomobil Kredisine Başvuru Yaptırdın!!\n ------------------");
        loanBaseManager.PrintLoanAppliedMessage();
        
        
        }

    public void LoanPreInfo(List<ILoanBaseManager> loans){
        foreach (ILoanBaseManager loan in loans){
            loan.PreInfo();
            }

        System.Console.WriteLine("_____________BİLGİLER MÜŞTERİYE SAĞLANDI_____________");
        }
   
   
    }
