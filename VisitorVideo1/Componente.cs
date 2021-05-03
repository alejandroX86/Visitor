using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorVideo1
{
    public abstract class Componente
    {
        string _serial;

        public Componente(string serial)
        {
            _serial = serial;
        }
        public string Serial { 
            get {
                return _serial;
            }
        }
        public  void Aceptar(IVisitor visitor)
        {
            visitor.Visitar(_serial);
        }
    }
}
