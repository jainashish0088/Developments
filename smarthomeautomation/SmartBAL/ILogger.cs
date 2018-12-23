using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBAL
{
    interface ILogger
    {
        Response WriteLog<Request, Response>(Request request);
    }
}
