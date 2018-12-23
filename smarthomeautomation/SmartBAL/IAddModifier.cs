using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBAL
{
    public interface IAddModifier
    {
        bool Add<T>(T detail);
        bool Update<T>(T detail);
    }
}
