using System.Collections.Generic;
namespace DAL.Models
{
    public class InstallmentHistory : AuditableEntity
    {
        public int Id { get; set; }
        public ICollection<Installment> Installments { get; set; }
    }
}
