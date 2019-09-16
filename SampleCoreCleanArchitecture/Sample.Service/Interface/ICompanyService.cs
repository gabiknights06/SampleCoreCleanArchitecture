using Sample.Core.Entities;
using Sample.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Service.Interface
{
    public interface ICompanyService<TData> : IBaseService<TData>
        where TData : ICompany
    {
        Company GetCompanyById(int id);
    }
}
