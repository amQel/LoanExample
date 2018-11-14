using DAL.Models;
using System.Collections.Generic;

namespace DAL.Core.Interfaces
{
    public interface IInstallmentCalculatorResolver
    {
        List<Installment> CalculateInstallments(double totalValue, int numberOfYears, InstallmentType installmentType);
    }
}
