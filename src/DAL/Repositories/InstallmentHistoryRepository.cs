using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Interfaces
{
    public class InstallmentHistoryRepository : Repository<InstallmentHistory>, IInstallmentHistoryRepository
    {
        public InstallmentHistoryRepository(DbContext context) : base(context)
        { }

        private ApplicationDbContext _appContext => (ApplicationDbContext)_context;
    }
}