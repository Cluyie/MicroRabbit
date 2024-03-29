﻿using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransforRepository : ITransferRepository
    {
        
        private TransferDbContext _dbContext;

        public TransforRepository(TransferDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(TransferLog transferLog)
        {
            _dbContext.TransferLogs.Add(transferLog);
            _dbContext.SaveChanges();
        }
        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _dbContext.TransferLogs;
        }
    }
}
