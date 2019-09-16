using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Service.Interface
{
    public interface IBaseService<TData>
    {
        int Insert(TData data);

        void Update(TData data);

        void Remove(TData data);

        List<TData> LoadAll();

        TData Load(int id);
    }
}
