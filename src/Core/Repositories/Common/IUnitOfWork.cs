using System;
using SM.Core.Repositories.User;

namespace SM.Core.Repositories.Common
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }
        int Compolete();
    }
}
