using Sample.Core.Entities;
using Sample.Core.Models;
using Sample.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Service.Interface
{
    public interface IPersonService<TData> : IBaseService<TData>
        where TData : IPerson
    {
        List<TData> FindRecord(string key, string value);

        List<TData> LoadAllReference(List<Person> person);
    }
}
