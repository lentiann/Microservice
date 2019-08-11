using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext context;

        public TransferRepository(TransferDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return context.TransferLogs;
        }

        public void Add(TransferLog transferLog)
        {
            context.TransferLogs.Add(transferLog);
            context.SaveChanges();
        }
    }
}
