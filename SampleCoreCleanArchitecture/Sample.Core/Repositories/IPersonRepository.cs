using Sample.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Core.Repositories
{
    public interface IPersonRepository<TData> : IBaseRepository<TData>
        where TData : IPerson
    {
        List<TData> FindRecord(string key, string value);
    }
}
