using databaseFirstProject.Interfaces;
using Repository.Models;

namespace databaseFirstProject.Services
{
    public class TransferServices : ITransferServices
    {
        private readonly SevenPayTestEfContext _context;
        public TransferServices(SevenPayTestEfContext context)
        {
            this._context = context;
        }

        public List<Transfer> getTransfers()
        {
            this._context.SaveChanges();
            return this._context.Transfers.ToList();
        }
    }
}
