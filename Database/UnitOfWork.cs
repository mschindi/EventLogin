using System;
using System.Threading.Tasks;
using EventLogin.CoreRepositories;
using EventLogin.CoreRepositories.IConfiguration;
using EventLogin.CoreRepositories.Repositories;
using Microsoft.Extensions.Logging;

namespace EventLogin.Database
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger _logger;
        
        public  IUserRepository Users { get; private set; }

        public UnitOfWork(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("logs");

            Users = new UserRepository(_context, _logger);
        }
        
        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public  void Dispose()
        {
            _context.Dispose();
        }
    }
}