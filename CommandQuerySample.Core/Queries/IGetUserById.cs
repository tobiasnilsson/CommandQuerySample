using CommandQuerySample.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandQuerySample.Core.Queries
{
    public interface IGetUserByIdQuery
    {
        User Get(int userId);
    }
}
