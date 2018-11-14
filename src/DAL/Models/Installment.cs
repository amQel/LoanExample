namespace DAL.Models
{
    public class Installment : AuditableEntity
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public int InstallmentNumber { get; set; }
        public InstallmentHistory InstallmentHistory { get; set; }
    }
}
