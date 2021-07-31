using MS.AFORO255.Security.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MS.AFORO255.Security.Services
{
    public interface IAccessService
    {
        IEnumerable<Access> GetAll();
        bool Validate(string userName, string password);
    }
}
