using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcFilters.Models
{
    internal interface IEjemploInterface
    {
        int GetNumeroEntero(string str);

        string GetCadenaDeCaracteres(int ent);

        double GetFlotante();
    }
}
