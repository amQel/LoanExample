// ====================================================
// More Templates: https://www.ebenmonney.com/templates
// Email: support@ebenmonney.com
// ====================================================

using DAL.Repositories.Interfaces;

namespace DAL
{
    public interface IUnitOfWork
    {
        IInstallmentHistoryRepository InstallmentHistories { get; }
        
        int SaveChanges();
    }
}
