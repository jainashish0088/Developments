using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBAL
{
    public class AddModifiers<T>
    {
        private readonly List<IAddModifier<T>> _lstAddModifier;
        public AddModifiers()
        {
            _lstAddModifier = new List<IAddModifier<T>>();
        }
        public bool Add(T request)
        {
            foreach (var addModifier in _lstAddModifier)
                addModifier.Add(request);
            return true;
        }
        public void Register(IAddModifier<T> addModifier)
        {
            _lstAddModifier.Add(addModifier);
        }
    }
}
