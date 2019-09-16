using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Core
{
    public interface IBaseRepository<TData>
    {
        int Insert(TData data);

        void Update(TData data);

        void Remove(TData data);

        List<TData> LoadAll();

        TData Load(int id);
    }
}
