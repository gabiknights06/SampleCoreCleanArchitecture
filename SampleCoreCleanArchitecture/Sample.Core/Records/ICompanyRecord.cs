using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Core.Records
{
    public interface ICompanyRecord : IBaseEntityRecord
    {
        string Name { get; set; }

        string Address { get; set; }
    }
}
