using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VehicleTrading.Core.Contracts.Uow;

namespace VehicleTrading.Persistence.Uow
{
    /// <inheritdoc />
    public class GenericUow : IUow
    {
        private readonly DbContext _context;

        #region Default Constructor

        /// <inheritdoc />
        public GenericUow(DbContext context) => _context = context;

        #endregion

        /// <inheritdoc />
        public void Dispose() => _context.Dispose();

        /// <inheritdoc />
        public async Task CompleteAsync() => await _context.SaveChangesAsync();

        /// <inheritdoc />
        public void Complete() => _context.SaveChanges();
    }
}
