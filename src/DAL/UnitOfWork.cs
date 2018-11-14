// ====================================================
// More Templates: https://www.ebenmonney.com/templates
// Email: support@ebenmonney.com
// ====================================================
using DAL.Repositories.Interfaces;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly ApplicationDbContext _context;

        IInstallmentHistoryRepository _installmentHistoryRepository;
               
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public IInstallmentHistoryRepository InstallmentHistories
        {
            get
            {
                if (_installmentHistoryRepository == null)
                    _installmentHistoryRepository = new InstallmentHistoryRepository(_context);

                return _installmentHistoryRepository;
            }
        }




        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
