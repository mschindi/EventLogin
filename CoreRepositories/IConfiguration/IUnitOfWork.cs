using System.Threading.Tasks;

namespace EventLogin.CoreRepositories.IConfiguration
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get;}
        Task CompleteAsync();
    }
}