using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace FreelanceProject.Core.Common
{
    public interface IDBContaxt
    {
        DbConnection Connection { get; }
    }
}
