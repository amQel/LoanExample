using DAL.Models;
using System.Collections.Generic;

namespace DAL.Core.Interfaces
{
    public interface IInstallmentCalculator
    {
        List<Installment> CalculateInstallments(double totalValue, int numberOfYears);
    }
}
