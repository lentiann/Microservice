using System.Collections.Generic;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferService transferService;
        private readonly IEventBus bus;

        public TransferService(ITransferService transferService, IEventBus bus)
        {
            this.transferService = transferService;
            this.bus = bus;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return transferService.GetTransferLogs();
        }
    }
}
