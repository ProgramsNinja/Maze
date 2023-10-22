using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Лаб4
{
    public interface ICloneablePrototype:IMapSite
    {
        ICloneablePrototype Clone(); 
    }
}
