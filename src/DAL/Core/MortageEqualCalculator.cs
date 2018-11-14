using DAL.Core.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;

namespace DAL.Core
{
    public class MortageEqualCalculator : IInstallmentCalculator
    {

        public MortageEqualCalculator()
        {
        }

        public List<Installment> CalculateInstallments(double totalValue, int numberOfYears)
        {
            throw new NotImplementedException();
        }
    }
}
