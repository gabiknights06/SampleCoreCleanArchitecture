using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Core
{
    public interface IBaseEntityRecord
    {
        int Id { get; set; }

        int RecordState { get; set; }

        DateTime Timestamp { get; set; }

        DateTime ModifiedTimestamp { get; set; }
    }
}
