using DAL.Core.Interfaces;
using DAL.Models;
using System.Collections.Generic;

namespace DAL.Core
{
    public class InstallmentCalculatorResolver : IInstallmentCalculatorResolver
    {

        public InstallmentCalculatorResolver()
        {
        }

        public List<Installment> CalculateInstallments(double totalValue, int numberOfYears, InstallmentType installmentType)
        {
            IInstallmentCalculator installmentCalculator;
            switch (installmentType)
            {
                case InstallmentType.Decreasing:
                    installmentCalculator = new MortageDecreasingCalculator();
                    break;
                case InstallmentType.Equal:
                    installmentCalculator = new MortageEqualCalculator();
                    break;
                default:
                    installmentCalculator = new MortageEqualCalculator();
                    break;
            }

            return installmentCalculator.CalculateInstallments(totalValue, numberOfYears);
        }
    }
}
