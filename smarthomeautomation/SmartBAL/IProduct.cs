using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBAL
{
    public interface IProduct<T,T1>
    {
        List<T1> ListRetreive(T request);
        T1 Retreive(T request);
    }
}
