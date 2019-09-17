using Sample.Core.Models;
using Sample.Core.Records;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Core.Entities
{
    public interface IPerson : IPersonRecord
    {
        Company CompanyRefence { get; set; }

        string FullName { get; }
    }
}
