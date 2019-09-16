using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Core.Records
{
    public interface IPersonRecord : IBaseEntityRecord
    {
        string FirstName { get; set; }

        string MiddleName { get; set; }

        string LastName { get; set; }

        int Company { get; set; }
    }
}
