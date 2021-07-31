using MS.AFORO255.Deposit.DTOs;
using System.Threading.Tasks;

namespace MS.AFORO255.Deposit.Services
{
    public interface IAccountService
    {
        Task<bool> TransacctionAccount(AccountRequest request);
        bool TransacctionReverse(Models.Transaction request);
        bool Execute(Models.Transaction request);

    }
}
