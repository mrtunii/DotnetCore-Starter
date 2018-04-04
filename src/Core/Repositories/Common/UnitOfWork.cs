using System;
using SM.Core.Repositories.User;

namespace SM.Core.Repositories.Common
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDBContext _context;

        public UnitOfWork(ApplicationDBContext context)
        {
            _context = context;
            UserRepository = new UserRepository(context);
        }
        public IUserRepository UserRepository { get; private set; }

        public int Compolete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
