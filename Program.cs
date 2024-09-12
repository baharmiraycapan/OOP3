// See https://aka.ms/new-console-template for more information
using System;
using OOP3;
using System.Collections.Generic;

namespace Generics{
    class Program{
        static void Main(string[] args){

            //PersonalLoanManager personalLoanManager = new PersonalLoanManager();
            //AutoLoanManager autoLoanManager = new AutoLoanManager();
            //MortgageLoanManager mortgageLoanManager = new MortgageLoanManager();

            ApplicationManager applicationManager = new ApplicationManager();
            //applicationManager.Apply(personalLoanManager);
            //applicationManager.Apply(autoLoanManager);
            //applicationManager.Apply(mortgageLoanManager);

            //Ahmet beyin almak istediği krediler tanımlanır.
            AutoLoanManager autoLoanManagerAHMET = new AutoLoanManager();
            MortgageLoanManager mortgageLoanManagerAHMET = new MortgageLoanManager();

            //AHMET beyin almak istediği kredileri bir listeye koy:
            List<ILoanBaseManager> loansAHMET = new List<ILoanBaseManager>(){autoLoanManagerAHMET, mortgageLoanManagerAHMET};

            //Bilgilendirmeyi yap
            applicationManager.LoanPreInfo(loansAHMET);
            
            //Ahmet beyin kabul ettiği kredileri database'e kaydet, ve mesaj gönder.
            //List<ILoggerService> lo   gs = new List<ILoggerService> (){autoLoanManagerAHMET,}

            applicationManager.Apply(autoLoanManagerAHMET, new List<ILoggerService> {new DatabaseLoggerService(), new SmsLoggerService()});
            applicationManager.Apply(mortgageLoanManagerAHMET, new List<ILoggerService> {new DatabaseLoggerService(), new SmsLoggerService()});
            
            }
        }
    }
