using Sample.Core.Entities;
using Sample.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Core.Repositories
{
    public interface ICompanyRepository<TData> : IBaseRepository<TData>
        where TData : ICompany
    {
        Company SearchCompanyById(int id);
    }
}
