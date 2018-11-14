using DAL.Core.Interfaces;
using DAL.Models;
using System.Collections.Generic;

namespace DAL.Core
{
    public class MortageDecreasingCalculator : IInstallmentCalculator
    {

        public MortageDecreasingCalculator()
        {
        }

        public List<Installment> CalculateInstallments(double totalValue, int numberOfYears)
        {
            //according to http://www.matematykafinansowa.pl equasion for nth installment is 
            //installment(n) = (totalValue/numberOfInstallments)*(1+(numberOfInstallments - n + 1)*nominalInterestRate/12)
            //we assume that every month we calculate intrest
            List<Installment> result = new List<Installment>();
            int numberOfInstallments = 12 * numberOfYears;
            for (int n=1; n <= numberOfInstallments; n++)
            {

                result.Add(new Installment
                {
                    Value = (totalValue / numberOfInstallments)
                          * (1 + (numberOfInstallments - n + 1) * (MortageLoanStatics.NOMINAL_INTEREST_RATE / 12)),

                    InstallmentNumber = n

                });
            }
            return result;
        }
    }
}
